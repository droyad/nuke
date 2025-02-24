<img width="400px" src="https://github.com/nuke-build/nuke/raw/develop/images/logo-black.png" />

> The AKEless Build System for C#/.NET

[![Latest Release](https://img.shields.io/nuget/v/nuke.common?logo=nuget&label=release&style=for-the-badge)](https://www.nuget.org/packages/nuke.common)
[![Latest Pre-Release](https://img.shields.io/nuget/vpre/nuke.common?logo=nuget&color=yellow&label=pre-release&style=for-the-badge)](https://www.nuget.org/packages/nuke.common/absoluteLatest)
[![Downloads](https://img.shields.io/nuget/dt/nuke.common.svg?style=for-the-badge&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAAHYcAAB2HAY%2Fl8WUAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTnU1rJkAAABrUlEQVR4XuXQQW7DMAxE0Rw1R%2BtN3XAjBOpPaptfsgkN8DazIDB8bNu2NCxXguVKsFwJlrJs6KYGS1k2dFODpSwbuqnBUpYN3dRgKcuGbmqwlGVDNzVYyrKhmxosZdnQTQ2WsmzopgZLWTZ0U4OlLBu6qcFSlg3d1GApy4ZuarCUZUM3NVjKsqGbGixl2dBNDZaybOimBktZNnRTg6UsG7qpwVKWDd3UYPnB86VKfl5owx9YflHhCbvHByz%2FcecnHBofsNzhjk84PD5gudOdnnBqfMDygDs84fT4gOVBVz4hNT5gecIVT0iPD1ieNPMJyviAZcKMJ2jjA5ZJI5%2Bgjg9YCkY8QR8fsJSYTxgyPmApMp4wbHzAUpZ5wtDxAcsBzjxh%2BPiA5SBHnjBlfMByoD1PmDY%2BYDnYtydMHR%2BwnICeMH18wHKS9ydcMj5gOVE84bLxAcuVYLkSLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLDvVQ5saLFeC5UqwXAmW69gev7WIMc4gs9idAAAAAElFTkSuQmCC)](https://www.nuget.org/packages/Nuke.Common/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=for-the-badge&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAAHYcAAB2HAY%2Fl8WUAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTCtCgrAAAADB0lEQVR4XtWagXETMRREUwIlUAIlUAodQAl0AJ1AB9BB6AA6gA6MduKbkX%2BevKecNk525jHO3l%2Fp686xlJC70%2Bl0C942vjV%2Bn9FreVQbBc0wWujfRpW8Z78JaIb53hhJ1ygTA80w9PQ36duBMjHQHPCuoQZfutSjeqU1PAJN4E3j2pN7aVKv6pnWcgGawNfGa5N6prVcgGZBn8yvVXZXQbOgPXokXaPMNZwoc41D%2FaHZ8b7hpBrKjnCizIjD%2FaHZ8aPR6%2BeZXqqh7Agnyow43B%2BaZz40qnQ36a6rlsYgnChDLOkPzTN1z%2B9PafU0N3OAcaIMsaQ%2FNBufG1X9JyrtDMr0Y4xwokxlWX%2BPjAYdemhPrWeDvYcPJ8r0LO3v4oszNfivQQuTp2u9qJGKE2V6lvZ38UVj9q3t3oqEE2U2lvfXF4t6qPjTqDUV1fRyhw8nymws768vfOr2NtqOqFY4UUZE%2BusL6VDRX7%2FGzOHDiTIi0t9WMPsUKzNPx4kysf62gmuHir3sPXw4USbWny485ZOc2PsJ7VTro%2F3pwp5DxV7qHq2xa41TrY%2F2J7PfJkaHir3UwwdtU061PtqfTP0CUaYm2v3LxCtoDI2lMWk8p1of7Y8K0jhRJgaaYZwoE0P%2FpFUndZqtP6T4BE2zC5qtP6T4BE2zC5qtPyRN8OvhZUQae3ZBtT7anyb49PA6Ivp5wKnWR%2FvbJkncZXr6wokysf62CXRCWjmJxhqd2JwoE%2BuvTqS37JGJlB39GLzhRJmN5f31gz8XTpSJgWYYJ8rEQDOME2VioBnGiTIx0AzjRJkYaIZxokwMNMM4USYGmmGcKBMDzTBOlImBZhgnysRAM4wTZWKgGcaJMjHQDONEmRhohnGiTAw0wzhRJgaaYZwoEwPNME6UiYFmGCfKxEAzjBNlYqAZxokyMdAMoL%2FO%2BNi4bzjpT1e%2BNFb8V7gFzUXMLHqk%2BM1A8wArFj1S5GagOUly0SMtuxloTnJrUU%2B7QXOSW4t62g2ak9xa1NNu0Jzk1qKednK6%2Bw9roIB8keT%2F3QAAAABJRU5ErkJggg%3D%3D)](LICENSE.md)

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Example](#example)
- [Continuous Integration](#continuous-integration)
- [Users](#users)
- [Sponsors](#sponsors)
- [Technology Sponsors](#technology-sponsors)

## Description

[<img align="right" width="130px" src="https://github.com/nuke-build/nuke/raw/develop/images/icon.png" />](https://nuke.build/)

**NUKE** is the most intuitive and productive build automation system for C#/.NET that runs cross-platform on .NET Core, .NET Framework, and Mono. While builds are bootstrapped with conventional Bash or PowerShell scripts, their actual implementation resides in simple [C# console applications](https://www.nuke.build/docs/authoring-builds/fundamentals.html). This approach unleashes the power of the type system and natively provides IDE features like code-completion, refactorings, and debugging. A custom [global tool](https://www.nuke.build/docs/running-builds/global-tool.html) and several [IDE extensions](https://www.nuke.build/docs/running-builds/from-ides.html) further improve how build projects are setup, authored and executed. A revolutionary code-generation approach ensures scalable [integration of third-party tools](https://www.nuke.build/docs/authoring-builds/cli-tools.html) like MSBuild or dotnet CLI.

For more information checkout the [resources](http://www.nuke.build/docs/getting-started/resources.html) and [FAQ](http://www.nuke.build/docs/getting-started/faq.html) sections.

[![Slack](https://img.shields.io/badge/slack-nukebuildnet-red.svg?style=for-the-badge&colorB=F5015F&logo=slack)](https://slofile.com/slack/nukebuildnet)
[![Twitter](https://img.shields.io/badge/twitter-%40nukebuildnet-blue.svg?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/nukebuildnet)

## Features

Here is a short list of some most-loved features:

- 🎲 [Easy to adopt in a team](https://www.nuke.build/docs/getting-started/philosophy.html)
- 🧠 [Comfortable to run](https://www.nuke.build/docs/running-builds/fundamentals.html)
- 🔥 [Powerful dependency model](https://www.nuke.build/docs/authoring-builds/fundamentals.html)
- 📥 [Parameter declarations](https://www.nuke.build/docs/authoring-builds/parameter-declaration.html)
- 👾 [Extensive tools support](https://www.nuke.build/docs/authoring-builds/cli-tools.html)
- ⚙️ [Deep CI integration](https://www.nuke.build/docs/authoring-builds/ci-integration.html)
- 🍀 [Build sharing options](https://www.nuke.build/docs/sharing-builds/fundamentals.html)
- 🗂 [Project model support](https://www.nuke.build/docs/authoring-builds/solutions-and-projects.html)
- 💾 [Abstraction of OS paths](https://www.nuke.build/docs/authoring-builds/system-paths.html)
- 🧩 [Extensibility points](https://www.nuke.build/docs/authoring-builds/events.html)
- 🔌 [IDE extensions](https://www.nuke.build/docs/running-builds/from-ides.html)
- 📝 [Logging and assertions](https://www.nuke.build/docs/authoring-builds/logging-and-assertions.html)
- ❤️ [Backed by community](#contributing)

## Example

<p align="center"><img width="800px" src="https://github.com/nuke-build/nuke/raw/develop/images/example-1.png" /></p>

## Continuous Integration

NUKE builds and tests itself on several different CI servers, which helps ensuring a working integration with those systems. At the same time, the individual configuration files serve as example for the [generation experience](https://www.nuke.build/docs/authoring-builds/ci-integration.html#configuration-generation):

| Build Server | Status | Platform | Configuration | 
|--------------|--------|:--------:|---------------|
| TeamCity | [![TeamCity](https://img.shields.io/teamcity/build/s/Nuke_Test?server=https%3A%2F%2Fnuke.beta.teamcity.com&label=build&style=flat-square&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAEEAAAA%2FCAYAAAC%2F36X0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTCtCgrAAAAC%2B0lEQVR4Xu2aDZHCMBSETwISkIAEJCABCUjAARKQgAQkIAEJSMhl75KbtOzLC%2FDyhpuwMx%2B0e7RNtvmj3FcIYXio%2BR9YrVZhvV7%2Fgf35Z1r5ednv98EbFLwsSI3FYhG22204Ho%2Fher1GS9btdgvn8znsdruwXC5h0XOW5A13IYioSWHmoBKo%2BCtCIFrgecNdtRBw5w%2BHQ9y0E8KQWkbecJcUAvr25XKJm%2FZCV0G3ippcM2%2B4i4WAAFDQ3kqt7O%2B6ecNd8xC8AoBwnbJrvEUIKJBXANBms8FbrvtvCBg0WtD6KirCjmOUfRP7rcI10JxRkXKdkKdQLczamNBEmmpEpcrQYyVSoVShcrUZJYOZBZ9jYczHgsydUaNHCNriB0KFHl0RIoyyhaX1Bv0sNSWsQ2hpBc8EUIK7n7ox%2FTugpoR1COWdkpSuSY%2B3gpoSliGguWqqNWFLqClhGUKapqp6pRs8AjUlLENII70orR9bQk0JyxC08UCaznpATQnPEPA8IIoeaw01JTxDSNeix1pDTYlPCBHPEFqWyFZQU8IzBK81AqCmhGUI2hSZvlPQY62hpoRlCC2LJa9xgZoSliG0LJsfOd8rUFPCMgRwOp3iW13sIcijaC2KmhLWIfT%2BKo3WloOuhUlNCesQQOtDFe1uzkFw88eBUhB3Ro0eIbQMkFmYNrWf1rRfrVgQkx2NHiGAlrGhFK6DKRYVQpnwPQP7rT%2FazIOYFEajVwjou60VsFLZve4KVKNXCAB9mD0h7qH5anRSEI2eIQAE0TJQviK2HJ%2FsaPQOAcwflVsJrextZwcJFNiqe6BctVmFmhKeIQC0CoTx7KCJWSeVmZ4%2FQ00JFAonlej5dBh3ElMh%2BjTCLscOtBh4AFMl1h4oaxQ91xxqjgY1R4Oao0HN0aDmaFBzNKg5GtQcDWqOBjVHg5qjQc3RoOZoUHM0qDka1BwNao7Gzwt7StQb7ZckT%2FKGuzz%2FHUcjb7jrE0LUJ4SoTwhRbxcCG717846zw8CEr2%2Fmetn3QDyWVAAAAABJRU5ErkJggg%3D%3D)](https://nuke.beta.teamcity.com/project/Nuke?mode=trends) | Win | [settings.kts](https://github.com/nuke-build/nuke/blob/develop/.teamcity/settings.kts) |
| GitHub Actions | [![GitHub Actions](https://img.shields.io/github/workflow/status/nuke-build/nuke/continuous?label=build&style=flat-square&logo=github&logoColor=white)](https://github.com/nuke-build/nuke/actions) | Win / Ubuntu / MacOS | [continuous.yml](https://github.com/nuke-build/nuke/blob/develop/.github/workflows/continuous.yml) |
| GitLab CI | [![GitLab CI](https://img.shields.io/gitlab/pipeline/matkoch/nuke/develop?label=build&style=flat-square&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAACAAAAAeCAYAAABNChwpAAAC%2BnpUWHRSYXcgcHJvZmlsZSB0eXBlIGV4aWYAAHja7ZdtjuQ4CIb%2F%2BxRzBAPG4OM4%2FpD2BnP8ee2kqqu6e7Z7tPtnpIoVk2ACFA9xVGH8%2FGeGHzjIi4ek5rnkHHGkkgpXXHg8j7JnimnP%2B%2BBrCfdP%2BkAj3iwoCqSct1Yv%2Bwq9vj1wi0HHsz74tcJ%2BOaL4FFpW5HXdH5OEnk89pctRuTLKxe0x1eNy1C7Dncp1pntap1j34UlhqFJXBBLmISRxz%2BnMQNZJUiEFM4nwqa2YPeyFmzMU5Onn3WSMjwV6KvLtKryv%2FoyfF5%2FrZSHvapmvGuHi0wXSd3q5x%2BfHwHLPiN8tyM3VxyLP2X3Ocf66mjIqmq%2BO2sWmmxsYHii57McyhuFUXNseBcNjjQ3Ie2zxwGhUiEFlBkrUqdKksWWjhhQTDzZI5gZQS%2BdiXLgBDCiuQZNNinRxMGs8AlAm4XsutOOWHa%2BRI3InmDLBGeGR347wb4t%2FMsKcbZWIdjHPWiEvXn2NNBa5NcMKQGhe3HQX%2BDYu%2FPGhsdCqIKi7zI4fWONxujiU3npLNmeBnUKerxAF65cDlAixFcmQgEDMJEqZojEbEeroAFSROUviAwRIlTuS5CSSORg7r9h4xmjbsnLmpcbeBBAqWQxsilTASknRP5YcPVRVNKlqVlMPWrRmySlrztny2uSqiSVTy2bmVqy6eHL17OaOzbAWLoI9UEsuVryUUiuHikAVvirsKzQHH3KkQ4982OFHOWpD%2B7TUtOVmzVtptXOXjm2i527de%2Bl1UBjYKUYaOvKw4aOMOtFrU2aaOvO06bPMeqd2Uf0w%2FoAaXdR4k1p2dqcGbTC7uaC1nehiBmKcCMRtEUBD82IWnVLiRW4xi4XxUigjSV1sQqdFDAjTINZJd3Zv5L7FLah%2Fixt%2FRS4sdP8HuQB0H7l9Qq2v71zbxM63cNU0Ct4%2B2FT2gDNGTP9Vfu0o43MqY93X9Rn9nQxfGXxXvhy9HL0cvRy9HL0c%2FX2O8OnGX8jwCy62fmDvb%2FgoAAABg2lDQ1BJQ0MgcHJvZmlsZQAAeJx9kT1Iw0AcxV9TpSKtDu0g4pChOlkQFXHUKhShQqgVWnUwufQLmhiSFBdHwbXg4Mdi1cHFWVcHV0EQ%2FABxc3NSdJES%2F5cUWsR4cNyPd%2Fced%2B8AoVFlmtU1Bmi6bWZSSTGXXxFDrwgigij6AJlZxqwkpeE7vu4R4Otdgmf5n%2FtzRNSCxYCASDzDDNMmXiee2rQNzvvEMVaWVeJz4lGTLkj8yHXF4zfOJZcFnhkzs5k54hixWOpgpYNZ2dSIJ4njqqZTvpDzWOW8xVmr1ljrnvyF4YK%2BvMR1mkNIYQGLkCBCQQ0VVGEjQatOioUM7Sd9%2FIOuXyKXQq4KGDnmsQENsusH%2F4Pf3VrFiXEvKZwEul8c52MYCO0CzbrjfB87TvMECD4DV3rbv9EApj9Jr7e1%2BBHQvw1cXLc1ZQ%2B43AEGngzZlF0pSFMoFoH3M%2FqmPBC9BXpXvd5a%2Bzh9ALLUVfoGODgERkqUvebz7p7O3v490%2BrvB%2BdScm%2FeJB%2FrAAAABmJLR0QA%2FwD%2FAP%2BgvaeTAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAB3RJTUUH5QMNExwAx4DC6AAAAbxJREFUSMfFVj0vBFEUPTMTDYlq1ypkKUQoNNhCQ0FYCuujQexfICEhLL1O4y8oJauk161Eg6iYjUJsa0Ui62hmYsy%2B%2BXrzzJ7kJZPcm3PO3Dvz7tVIQoATAF8AdqEGJQAZAJvugOZhoAagAaBbkYFXAPp3o9GlG8afgC5IngGQshxPKhDPWVxp3TDy7qDIgFN0VoGBguN5sSlK0n2q%2FMWzIB71mA6%2BqjvuTh5lM8ZiiA8K%2BHLOHHcLlgQlXIhR%2FrWAljRV4Eng%2BCFGBW4EfKZXC%2FrpjT4J8awP34ioBas%2BpVyXKH%2FRJzYvakHFx3FFogLXPnx3dp59E2YBmAFvtAXgM%2BTbtwE4DcjpBVC13e4zeZSc38A0kkfBHkZpAG9oDXp0j8snKazoAJZbaGBOo8dCkBR0AIct1D%2Byf8Mpki8J%2FoI1knn3LMiQvEpA%2FNI5W0RX6MF%2FXz5%2BC4l9xq1tSBVMkhMiLb9h0kmyrED8gmTKSyfMVNshWZcQfie5HcQfdrQOk3yMWPJQu2SU%2Bd5O8iyE%2BLmVC9UG7LPh0ZI6yWJUPtllc4DkrUP8nuSQDJcWYxR0ADi2nvcAfMiQ%2FABfcxql0NZJXwAAAABJRU5ErkJggg%3D%3D&logoColor=white)](https://gitlab.com/matkoch/nuke/-/pipelines) | Ubuntu | [.gitlab-ci.yml](https://github.com/nuke-build/nuke/blob/develop/.gitlab-ci.yml) |
| Azure Pipelines | [![Azure Pipelines](https://img.shields.io/azure-devops/build/nuke-build/db5bcee5-db3e-430e-980b-96372b5b7941/7.svg?style=flat-square&label=build&logo=azure-pipelines&logoColor=white)](https://dev.azure.com/nuke-build/NUKE/_build?definitionId=7) | Win / Linux / MacOS | [azure-pipelines.yml](https://github.com/nuke-build/nuke/blob/develop/azure-pipelines.yml) |
| AppVeyor | [![AppVeyor](https://img.shields.io/appveyor/ci/matkoch/nuke-continuous/develop.svg?style=flat-square&label=build&logo=appveyor&logoColor=white)](https://ci.appveyor.com/project/matkoch/nuke-continuous) | Win / Ubuntu | [appveyor.yml](https://github.com/nuke-build/nuke/blob/develop/appveyor.continuous.yml) |

[comment]: <> (| Bitrise | [![Bitrise]&#40;https://img.shields.io/bitrise/ffbfd67a7e3f1561/develop.svg?token=AsgY8yIy6MzdWs0cncU2Jg&style=flat-square&logo=bitrise&label=build&#41;]&#40;https://www.bitrise.io/app/ffbfd67a7e3f1561#/builds&#41; | Ubuntu | [bitrise.yml]&#40;https://github.com/nuke-build/nuke/blob/develop/bitrise.yml&#41; |)
[comment]: <> (| Travis CI | [![Travis CI]&#40;https://img.shields.io/travis/nuke-build/nuke/develop?style=flat-square&label=build&logo=travis-ci&logoColor=white&#41;]&#40;https://travis-ci.org/nuke-build/nuke&#41; | MacOS / Ubuntu | [.travis.yml]&#40;https://github.com/nuke-build/nuke/blob/develop/.travis.yml&#41; |)
[comment]: <> (| Jenkins | [![Jenkins Build]&#40;https://img.shields.io/jenkins/s/https/jenkins.nuke.build/job/nuke-build/job/nuke/job/develop.svg?style=for-the-badge&label=jenkins&logo=%20data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM%2FrhtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMjHxIGmVAAAGBklEQVRYR82YfayWcxjHT%2B%2BnkuQlU2e9iE6MiJS%2FakOLFCvOJHGY1kRYRqNh2LAOUXZaTJFWMubloGYtm7Nl8tZ0hlUzJ0dFRVGhF53j8%2F093%2Ftxnufc9%2FNyTjbf7bvf77qu73Xd93M%2Fv%2Fv3cpe0BU1NTaWNjY0Xw2nwSbgMroK1cD38BK5BtxTeT380bSen%2FzfgAj250G1wLTyIHQtih%2BE%2BeMSuAOxf4bOwzCWPDajdjaKPwX2pS2UC%2Fx9wGd0K2v607Z3XHrsvvAJWwXrr%2F4T3Rbo2gSKnU%2BwbFc4G%2FqNwETzF8pwgRTc8Gf7g%2FDdhF4eLB8m9o2LZwL8fjre0KJCuobLKdd6gaedQcSB5pYpkA%2F9fcJRlrQJlOlFjtevNsrtwkNQfHlWBbOCfYVmbQKkTqPUjPAD72J0fiLvCFanbyYSLtRg3%2BE6DI5AMgR3sjgU61R8I9QJNcd35DucH4reVlATiYy3VUzgf%2B%2BNUJI0BDseC%2BPSULNTa43YvTaklyUCoCTUfKqSlHYL%2Bd3gEvgofgnNDoRxAUw4Xkb%2BU9rtQEdCfYEkyED1tfSyIC%2F2trUmZjRNDcitAyQ7kL3Tt%2FH8zonckTgLxWkulHQ%2FvsJkGPq02NchzTh9oytF8RHsD1OqzzqFkIArzUxKIT7U0EWietzY9FdHXSvIh7vTqgX0mPAS%2FhZvhboeSgWi5iseBmMZaD0sTgWak9cvtkq%2FavvPsCsCeZ%2F%2FfUCtT7pUF7SNKiAPJDZYlAllHtWg%2Fhwdh2BjQjnWNBbYrYR2slT8Cdm%2FFE4Gg%2BUvym9sAYodoeloaCzTacmm79bVzZspPV%2Buw%2Fkrd9NlwDvwF6qlp87DD%2BoGhUBwI3mTROpoL7XtYvgjYVwdxDAhrj7gGhq0Y7VY42GHVuhTqhrbAvvIh6wz1JmvaUc6gIM4GsY4Ed8Bt9I%2BTkLYdbZkSI2Df45REINM6exJti%2B0Ufm2zVKcepm%2BG%2Fkv2xy95BC6wYB7sAXWzsx3TAN4G70SSf7bPA%2BrMgoL2hyfb95Yc2N2CKBvEokGs5Bvdv9uxGZhtvrHmoOYcX6PKtsatNsTxcyfB6Ak%2BB%2B%2BFm%2BBQh1sNagyHGX8btjYJL%2Fh6mjM1lHQc2GhJSyDSuNkJd8ET7W4zqKXDlFaJ66H%2BHb3lh31zX0HtgsI4p13htHgg0BiTUHPYGfJh9qOvbX1YfwsF%2BuPdzlTNCNh6i7X7uZm2qzT0KxwLQyoRaPSo51usF%2BMz2GD7WsvyAu25cA%2FU8lYGr4R3wUnwVF9Hvu%2FhdXCxr1HYkEI4Dq4lJ0zU9KsdKgjoR8DNztUT2wh1QNL41s1vdUzr8O1wN9QbXdzZhKSwN6R9wq4A7NlQW%2FXYSRW%2FnpLG9FT4PtSKIWgVGQp%2FhkvQaD95Tdw1CgJ5nUncCzPeLuzJLvq4XWngewbqqU1DEtZl2nawFPZSPwiB%2Buj0BUKbkOQlLhdIjKaDc%2BySrwtsgDqflNsdgD0Y7nKOdtsb6H5Bq4m%2B3rIA7InWpXc9RYN8nTmExXYFYE9IucONXmR3AHYf%2BBTcADW%2B9Bdrv6e%2Fu7s1OjXqpg9wjZxnmJwg%2BTKKROeOYXYHYGuA621XbCEs6JsLukEweom0pOY%2Fi2SDJB1s3lORCNjb4XBLArBHwS2Oa0LWOaUScwDMeCvx66k9CvdL3xz43qXpZ2kyEOkwrYEeZvts4NfTehmOwexFq7kt6aOSvnBpydQ0E%2FZ7uYBG%2F1T8kYK4NpS3wp0peeEgR%2BvoXLgEbrc7AFs7lDQwV8ORUOeROrvTwCeM8W2lgGMYXG9NQUD%2FAc3r7q90Kf1Q7SunwC8Vi4D9E5xkWQD2AoezMd2SIHoAZnxoLATkaK6LlsXXXC4D%2BC%2BBL8Jq2OITHb6qUCwL%2BK8KAvqaiGM%2FEBUDasTeYD6Q94pLZAD%2FWZYE0af2txrUqHG5NHBrTI%2Bj1ecNfRYR9flXf%2F%2Fl%2BKfThu8yzYFP55l%2Fv2XjuCUVaj2osYlGN9QdjoZ6YcKGoFiQV%2BdbSwGfvj%2Fry1KbQA0te8diuLRc9nA%2BCLX3%2Bz%2BwMnVXJSX%2FACrjqI7wt59WAAAAAElFTkSuQmCC&#41;]&#40;https://jenkins.nuke.build/blue/organizations/jenkins/nuke-build%2Fnuke/branches/&#41; |)

## Users

- [ASP.NET Boilerplate](https://aspnetboilerplate.com/) <sup><a href="https://github.com/aspnetboilerplate/aspnetboilerplate">1</a></sup>
- [AvaloniaUI](https://avaloniaui.net/) <sup><a href="https://github.com/AvaloniaUI/Avalonia">1</a></sup>
- **[Aviva Solutions Inc.](https://www.avivasolutions.com/)** <sup><a href="https://github.com/avivasolutionsnl/sitecore-commerce-docker">1</a> <a href="https://github.com/avivasolutionsnl/sitecore-docker">2</a></sup>
- [ChilliCream](https://chillicream.com/) <sup><a href="https://github.com/ChilliCream/hotchocolate">1</a></sup>
- [CvsHelper](https://joshclose.github.io/CsvHelper/) <sup><a href="https://github.com/JoshClose/CsvHelper">1</a></sup>
- [DNN Community](https://dnncommunity.org/) <sup><a href="https://github.com/DNNCommunity/Dnn.ModuleCreator">1</a></sup>
- [FluentAssertions](https://fluentassertions.com/) <sup><a href="https://github.com/fluentassertions/fluentassertions">1</a></sup>
- **[JetBrains s.r.o.](https://www.jetbrains.com/)** <sup><a href="https://github.com/JetBrains/space-dotnet-sdk">1</a> <a href="https://github.com/JetBrains/YouTrackSharp">2</a></sup>
- **[Octopus Deploy Pty. Ltd.](https://www.octopus.com/)** <sup><a href="https://github.com/OctopusDeploy/Time">1</a> <a href="https://github.com/OctopusDeploy/Shellfish">2</a> <a href="https://github.com/OctopusDeploy/Ocl">3</a></sup>
- [OmniSharp](http://www.omnisharp.net/) <sup><a href="https://github.com/OmniSharp/csharp-language-server-protocol">1</a></sup>
- **[VirtoCommerce](https://virtocommerce.com/)** <sup><a href="https://github.com/VirtoCommerce/vc-build/">1</a></sup>

## Sponsors

Thanks to all companies, organizations, and individuals who are sponsoring the further development of this project. Your support means a lot! 💙


[<img height="140px" src="https://raw.githubusercontent.com/nuke-build/nuke/develop/images/virto-commerce.png" alt="Virto Commerce" />](https://virtocommerce.com/)

[<img height="150px" src="https://octopus.com/images/company/OctopusDeploy-logo-RGB.svg" alt="Octopus Deploy" />](https://octopus.com)

[<img height="65px" src="https://www.dangl-it.de/media/1195/logo-en-rectangular.png" alt="Dangl-IT GmbH" />](https://www.dangl-it.com/)
[<img height="65px" src="https://peiitalliance.com/logos/LevelingUp-Logo.svg" alt="Leveling Up" />](https://github.com/ron-myers)

[![Rodney Littles II](https://avatars.githubusercontent.com/RLittlesII?s=60&v=4)](https://github.com/RLittlesII)
[![Olga Nelioubov](https://avatars.githubusercontent.com/onelioubov?s=60&v=4)](https://github.com/onelioubov)
[![Vova Lantsov](https://avatars.githubusercontent.com/vova-lantsov-dev?s=60&v=4)](https://github.com/vova-lantsov-dev)
[![Daniel Valadas](https://avatars.githubusercontent.com/valadas?s=60&v=4)](https://github.com/valadas)
[![Anton Wieslander](https://avatars.githubusercontent.com/T0shik?s=60&v=4)](https://github.com/T0shik)
[![Chase Florell](https://avatars.githubusercontent.com/ChaseFlorell?s=60&v=4)](https://github.com/ChaseFlorell)
[![business//acts](https://avatars.githubusercontent.com/BusinessActs?s=60&v=4)](https://github.com/BusinessActs)

[![Stephan Müller](https://avatars.githubusercontent.com/chaquotay?s=45&v=4)](https://github.com/chaquotay)
[![Bitbonk](https://avatars.githubusercontent.com/bitbonk?s=45&v=4)](https://github.com/bitbonk)
[![Marat Gumerov](https://avatars.githubusercontent.com/Marat-Gumerov?s=45&v=4)](https://github.com/Marat-Gumerov)
[![Thomas Unger](https://avatars.githubusercontent.com/tunger?s=45&v=4)](https://github.com/tunger)
[![Matt Brailsford](https://avatars.githubusercontent.com/mattbrailsford?s=45&v=4)](https://github.com/mattbrailsford)
[![David Driscoll](https://avatars.githubusercontent.com/david-driscoll?s=45&v=4)](https://github.com/david-driscoll)
[![Actipro Software](https://avatars.githubusercontent.com/Actipro?s=45&v=4)](https://github.com/Actipro)
[![Logan Laughlin](https://avatars.githubusercontent.com/llaughlin?s=45&v=4)](https://github.com/llaughlin)
[![Alex Sink](https://avatars.githubusercontent.com/hardcoded2?s=45&v=4)](https://github.com/hardcoded2)
[![Martin Gill](https://avatars.githubusercontent.com/MartinSGill?s=45&v=4)](https://github.com/MartinSGill)
[![Trey Cook](https://avatars.githubusercontent.com/hfcook3?s=45&v=4)](https://github.com/hfcook3)
[![Todor Todorov](https://avatars.githubusercontent.com/totollygeek?s=45&v=4)](https://github.com/totollygeek)
[![Christian Sindberg](https://avatars.githubusercontent.com/chrsin?s=45&v=4)](https://github.com/chrsin)
[![Andrei Andreev](https://avatars.githubusercontent.com/Razenpok?s=45&v=4)](https://github.com/Razenpok)
[![Steven Kuhn](https://avatars.githubusercontent.com/stevenkuhn?s=45&v=4)](https://github.com/stevenkuhn)

## Technology Sponsors

Thanks to [JetBrains](https://jetbrains.com) for providing licenses for [Rider](https://jetbrains.com/rider) and access to a [TeamCity Cloud](https://jetbrains.com/teamcity) instance, which both make open-source development a real pleasure!

[<img src="https://raw.githubusercontent.com/nuke-build/nuke/develop/images/jetbrains.png" width="450" />](https://jetbrains.com/)
