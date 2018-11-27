#!/bin/bash

declare genero=""

read -p "Ingrese su genero: " genero

if [genero == "M"]; then
	echo "Usted es varon"
else
	echo "Usted es mujer"

fi
