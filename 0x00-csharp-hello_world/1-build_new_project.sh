#!/usr/bin/env bash
# builds a new C# project inside a folder
dotnet new console -n 1-new_project
dotnet build --no-restore 1-new_project/1-new_project.csproj
