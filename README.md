![Valve Logo](https://github.com/benefactor-org/valve-dotnet-core/blob/master/valve-logo.png =100x100)

# Valve[C#]: Sampling and feature release control for better customer experience.

[![][nuget img]][nuget]
[![][license img]][license]

### [NuGet Package](https://www.nuget.org/packages/Valve/)

## Introduction

Valve is a simple to integrate sampling and code flow control library, which can perform sampling on an unknown size of identifiers. It was developed to fullfill the need to perform percentage based roll out of a certain feature for users.

## Documentation

```
   String identifier = "useremail@email.com" // unique identifier per sample like user_id 
   int percentEnabled = 20; // percentage for which feature should be enabled

   if (Valve.Valve.Control(identifier, percentEnabled)) 
   {
       Console.WriteLine("Feature is enabled for identifier.");
   } 
   else 
   {
       Console.WriteLine("Fearure is not available for this identifier.");
   }
```


## Communication

- [GitHub Issues](https://github.com/benefactor-org/valve-dotnet-core/issues)

## What does it do?

#### 1) Sampling

Given a unique identifier and roll out percentage, decides weather to be sampled or not to be sampled.

#### 2) Feature gates for enabling or disabling a perticular feature.[WIP]

You can configure Valve with all your features at the application start up, and dynamically enable or disable it during runtime.

## Bugs and Feedback

For bugs, questions and discussions please use the [GitHub Issues](https://github.com/benefactor-org/valve-dotnet-core/issues).

 
## LICENSE

Copyright 2020 Benefactor, Org.

Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

<https://github.com/benefactor-org/valve-dotnet-core/blob/master/LICENSE>

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

[nuget img]:https://img.shields.io/nuget/v/valve
[nuget]:https://www.nuget.org/packages/Valve/
[license]:LICENSE
[license img]:https://img.shields.io/github/license/benefactor-org/valve
