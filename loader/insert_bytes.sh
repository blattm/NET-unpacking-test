#!/bin/bash
source_path=../hello_world/bin/Debug/netstandard2.0/hello_world.dll
target_path=Program.cs

b64=$(base64 -w 0 $source_path)

old=$(grep 'string s = ' $target_path)

new="        string s = \"$b64\";"
#echo sed -e "s/$old/$new/" > ${target_path}_temp
while IFS= read -r line;do
  if [[ "$line" == "$old" ]]; then
    echo "$new"
  else
    echo "$line"
  fi
done  < $target_path >  ${target_path}_temp
mv ${target_path}_temp $target_path