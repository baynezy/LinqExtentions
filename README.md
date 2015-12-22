# LinqExtensions

A Library of extensions for Linq

## Build Status

<table>
    <tr>
        <th>master</th>
		<td><a href="https://ci.appveyor.com/project/baynezy/linqextensions"><img src="https://ci.appveyor.com/api/projects/status/x3e8lv4uo02mpnr1/branch/master?svg=true" alt="master" title="master" /></a></td>
    </tr>
    <tr>
        <th>develop</th>
		<td><a href="https://ci.appveyor.com/project/baynezy/linqextensions"><img src="https://ci.appveyor.com/api/projects/status/x3e8lv4uo02mpnr1/branch/develop?svg=true" alt="develop" title="develop" /></a></td>
    </tr>
</table>

## Nuget

[![NuGet version](https://badge.fury.io/nu/LinqExtensions.svg)](http://badge.fury.io/nu/LinqExtensions)

### Install

    PM> Install-Package LinqExtensions

## Currently supported

### Each

    var numbers = new {1,2,3,4};
    numbers.Each(Console.WriteLine);