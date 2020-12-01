#!/usr/bin/env bash
# runs a new C# project inside a folder
dotnet new console -o 2-new_project
dotnet build 2-new_project/
dotnet run --project 2-new_project/
