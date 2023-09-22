#!/bin/bash

soFix='NAME="Arch Linux"'
so=$(cat /etc/os-release | grep -i -w 'name="arch linux"')
if [ "$so" == "$soFix" ]; then
    sudo pacman -Syu -y
    sudo pacman -S apache -y
    sudo pacman -S unzip -y
    cd /tmp
    wget https://github.com/denilsonbonatti/linux-site-dio/archive/refs/heads/main.zip
    unzip main.zip
    cd linux-site-dio-main
    cp -r * /var/www/html

else
    apt-get update -y
    apt-get upgrade -y
    apt install apache2 -y
    apt install unzip -y
    cd /tmp
    wget https://github.com/denilsonbonatti/linux-site-dio/archive/refs/heads/main.zip
    unzip main.zip
    cd linux-site-dio-main
    cp -r * /var/www/html
fi