#!/bin/sh

currentbranch=`git branch | awk '/\*/ { print $2; }'`
number=`git rev-list --count $currentbranch`

echo $number 'commits on this branch'
