﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsld.Params
{
    class DefaultOptions
    {
        [Option('o', "directory", Required = false, HelpText = "Directory to install.")]
        public string InstallDir { get; set; }

        [Option('i', "image", Required = true, HelpText = "Docker Image to Install.")]
        public string Dockerimage { get; set; }

        [Option('d', "distroname", Required = true, HelpText = "Name to give to the new distro")]
        public string Distroname { get; set; }

        [Option('v', "version", Required = false, HelpText = "Version for the new distro, the default is the wsl default, set 1 to WSL1, 2 to WSL2.")]
        public int Version { get; set; }

        [Option('g', "createuser", Required = false, Default = false, HelpText = "If set, creates a default user. If the docker image doesn't have a root user, do not use.")]
        public bool CreateUser { get; set; }

        [Option('u', "user", Required = false, Default = "user", HelpText = "Create a user name, default: user")]
        public string User { get; set; }

        [Option('p', "password", Required = false, Default="user", HelpText = "Create a default password for the user, default: user")]
        public string Password { get; set; }
        
    }

    class DockerOptions
    {


        [Option("upload", Required = false, HelpText = "Link wlsd with your docker account!")]
        public string upload { get; set; }

    }

    class DockerLoginOptions
    {
        [Option('u', "user", Required = false, Default = null, HelpText = "Link wlsd with your docker account!")]
        public string User { get; set; }

        [Option('p', "password", Required = false, Default = null, HelpText = "Link wlsd with your docker account!")]
        public string Password { get; set; }
    }

    class DockerUploadOptions
    {
        [Option('d', "distroname", Required = true, HelpText = "Name of the distro to upload")]
        public string Distroname { get; set; }

        [Option('i', "image", Required = true, HelpText = "Image to upload format: repository/image:tag")]
        public string Dockerimage { get; set; }

    }

    class DockerfileOptions
    {
        [Option('d', "distroname", Required = true, HelpText = "Name of the result distro")]
        public string Distroname { get; set; }

        [Option('f', "file", Required = false, HelpText = "Dockerfile to build, if using remote, URL.")]
        public string Dockerfile { get; set; }

        [Option('r', "remote", Required = false,  Default = false, HelpText = "Add this if the f is a URL")]
        public bool remote { get; set; }
    }
}
