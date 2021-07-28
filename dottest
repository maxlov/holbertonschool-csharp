#!/usr/bin/env bash
# Creates task directory from argument 1 with class library names from argument 2. Eg: ./script 0-add MyMath
if [ $# -eq 2 ];
then
        tests="$2".Tests
        new='  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>'
        old='  <PropertyGroup>'
        mkdir "$1"
        cd "$1"
        dotnet new sln
        dotnet new classlib -o "$2"
        cd "$2"
        mv Class1.cs "$2".cs
        sed -i "s@^$old@$new@" "$2".csproj
        cd ..
        dotnet sln add "$2"/"$2".csproj
        dotnet new nunit -o "$tests"
        cd "$tests"
        mv UnitTest1.cs "$tests".cs
        dotnet add reference ../"$2"/"$2".csproj
        cd ..
        dotnet sln add "$tests"/"$tests".csproj
        group=$(groups "$USER" | tr -d " ")
        chown -R "$group" .
        chown -R "$group" /tmp/NuGetScratch/lock
        chmod -R g+w .
        chmod -R g+w /tmp/NuGetScratch/lock
else
        echo "Usage: ./mktest <task directory> <classlibrary>"
fi
