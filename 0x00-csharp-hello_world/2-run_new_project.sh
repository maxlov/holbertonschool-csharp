#!/usr/bin/env bash
# creates new project with console templates then builds and runs it
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project/2-new_project.csproj
