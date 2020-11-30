#!/usr/bin/env bash
# runs a new C# project inside a folder
dotnet new console -n 2-new_project
dotnet build --no-restore 2-new_project/2-new_project.csproj
dotnet run --project 2-new_project/2-new_project.csproj
