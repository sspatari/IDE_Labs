# Integrated Developement Enviroments Laboratory Work Nr.1
## Setting server environment. Version Control Systems

For this laboratory work as a remote server I will use a Ubuntu 15.04 Virtual Mashine.

## Connect via ssh

- Lets first of all check if we can see the machine. Ping it using ``` ping -c 192.168.0.102``` You should get something like this:

![Alt](images/ping.png)

Now we can easily connect with ssh to our remote server. In linux distributors we type in ```ssh  ubuntu@192.168.0.102```. You have to enter password to your ubuntu server.

![Alt](images/server_connect.png)

- Next we will install fish shell, a smart and user-friendly command line shell for Linux. More information [here](https://fishshell.com/).  
For installing fish we have to run following commands:
   * `sudo apt-add-repository ppa:fish-shell/release-2`
   * `sudo apt-get update`
   * `sudo apt-get install fish`
   * `fish` (to switch to fish shell)
   * `curl -L https://get.oh-my.fish | fish` (to install oh-my-fish. Check it [here](https://github.com/oh-my-fish/oh-my-fish))
   * `omf install simple-ass-prompt` (to install a simple theme)
Shell should look like:

![Alt](images/fish_shell.png)

- Now we can perform any command from our terminal!

## Set up git

- First of all we have to install git `sudo apt-get install git`
- Configure global user	name `git config --global user.name "sspatari"`
- Configure global user	email `git config --global user.email "spatari.stanislav@gmail.com"`
- Generate ssh key with `ssh-keygen`
- Set the public key in github
- Now we will clone the created remote repository `git clone git@github.com:sspatari/IDE_Labs.git`
- Now we can work further on this project
