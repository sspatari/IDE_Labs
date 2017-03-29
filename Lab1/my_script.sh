#!/bin/sh
echo Enter file name
read FILE
case $FILE in
        *.cpp) g++ hello_world_files/$FILE -o ${FILE%.*} && ./${FILE%.*}
        ;;
        *.c) gcc hello_world_files/$FILE -o ${FILE%.*} && ./${FILE%.*}
        ;;
        *.py) python hello_world_files/$FILE
        ;;
        *.js) nodejs hello_world_files/$FILE
        ;;
        *.rb) ruby hello_world_files/$FILE
        ;;

esac
