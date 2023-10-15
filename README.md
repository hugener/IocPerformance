# Ioc Performance

[![Build Status](https://github.com/danielpalme/IocPerformance/workflows/Smoketest/badge.svg)](https://github.com/danielpalme/IocPerformance/workflows/Smoketest/badge.svg)

Source code of my performance comparison of the most popular .NET IoC containers:  
[www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison](https://www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison)

Author: Daniel Palme  
Blog: [www.palmmedia.de](https://www.palmmedia.de)  
Twitter: [@danielpalme](https://twitter.com/danielpalme)  

## Results
### Explantions
**First value**: Time of single-threaded execution in [ms]  
**Second value**: Time of multi-threaded execution in [ms]  
### Basic Features
|**Container**|**Singleton**|**Transient**|**Combined**|**Complex**|
|:------------|------------:|------------:|-----------:|----------:|
|**[abioc 0.8.0](https://github.com/JSkimming/abioc)**|12<br/>32|16<br/>**31**|**25**<br/>55|34<br/>37|
|**[Autofac 7.0.1](https://github.com/autofac/Autofac)**|330<br/>207|403<br/>245|1093<br/>652|3509<br/>1860|
|**[DryIoc 4.8.5](https://github.com/dadhi/DryIoc)**|27<br/>27|32<br/>40|36<br/>**45**|47<br/>44|
|**[DryIocZero 4.0.0](https://github.com/dadhi/DryIoc)**|58<br/>41|47<br/>41|48<br/>46|105<br/>71|
|**[Microsoft Extensions DependencyInjection 7.0.0](https://github.com/aspnet/Extensions)**|27<br/>26|36<br/>39|36<br/>50|46<br/>46|
|**No**|13<br/>**19**|17<br/>**31**|27<br/>42|31<br/>44|
|**[Pure.DI 2.0.15](https://github.com/DevTeam/Pure.DI)**|11<br/>**19**|16<br/>33|27<br/>46|32<br/>40|
|**[Sundew.Injection 0.1.0.0](Sundew.Injection)**|99<br/>75|114<br/>79|131<br/>88|190<br/>116|
|**[Sundew.Injection.Hash 0.1.0.0](Sundew.Injection.Hash)**|10<br/>26|**15**<br/>**31**|**25**<br/>**45**|**30**<br/>**36**|
|**[Sundew.Injection.Hash2 0.1.0.0](Sundew.Injection.Hash2)**|**9**<br/>26|16<br/>**31**|26<br/>46|31<br/>39|
|**[Unity 5.11.10](https://github.com/unitycontainer/unity)**|90<br/>61|660<br/>361|1445<br/>745|3426<br/>1754|
### Advanced Features
|**Container**|**Generics**|**IEnumerable**|
|:------------|-----------:|--------------:|
|**[abioc 0.8.0](https://github.com/JSkimming/abioc)**|<br/>|322<br/>186|
|**[Autofac 7.0.1](https://github.com/autofac/Autofac)**|845<br/>500|3557<br/>1929|
|**[DryIoc 4.8.5](https://github.com/dadhi/DryIoc)**|36<br/>42|125<br/>88|
|**[DryIocZero 4.0.0](https://github.com/dadhi/DryIoc)**|45<br/>43|135<br/>88|
|**[Microsoft Extensions DependencyInjection 7.0.0](https://github.com/aspnet/Extensions)**|35<br/>39|127<br/>86|
|**No**|**21**<br/>32|86<br/>67|
|**[Pure.DI 2.0.15](https://github.com/DevTeam/Pure.DI)**|**21**<br/>**33**|**85**<br/>**64**|
|**[Sundew.Injection 0.1.0.0](Sundew.Injection)**|<br/>|278<br/>166|
|**[Sundew.Injection.Hash 0.1.0.0](Sundew.Injection.Hash)**|<br/>|106<br/>80|
|**[Sundew.Injection.Hash2 0.1.0.0](Sundew.Injection.Hash2)**|<br/>|108<br/>82|
|**[Unity 5.11.10](https://github.com/unitycontainer/unity)**|3122<br/>1627|6529<br/>3427|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**[abioc 0.8.0](https://github.com/JSkimming/abioc)**|2586<br/>|2388<br/>|
|**[Autofac 7.0.1](https://github.com/autofac/Autofac)**|121<br/>|131<br/>|
|**[DryIoc 4.8.5](https://github.com/dadhi/DryIoc)**|24<br/>|27<br/>|
|**[DryIocZero 4.0.0](https://github.com/dadhi/DryIoc)**|**0**<br/>|**0**<br/>|
|**[Microsoft Extensions DependencyInjection 7.0.0](https://github.com/aspnet/Extensions)**|9<br/>|13<br/>|
|**No**|**0**<br/>|**0**<br/>|
|**[Pure.DI 2.0.15](https://github.com/DevTeam/Pure.DI)**|**0**<br/>|<br/>|
|**[Sundew.Injection 0.1.0.0](Sundew.Injection)**|**0**<br/>|**0**<br/>|
|**[Sundew.Injection.Hash 0.1.0.0](Sundew.Injection.Hash)**|**0**<br/>|**0**<br/>|
|**[Sundew.Injection.Hash2 0.1.0.0](Sundew.Injection.Hash2)**|**0**<br/>|**0**<br/>|
|**[Unity 5.11.10](https://github.com/unitycontainer/unity)**|42<br/>|107<br/>|
### Charts
![Basic features](https://raw.githubusercontent.com/danielpalme/IocPerformance/master/docs/img/Overview_Basic_Fast.png)
![Advanced features](https://raw.githubusercontent.com/danielpalme/IocPerformance/master/docs/img/Overview_Advanced_Fast.png)
![Prepare](https://raw.githubusercontent.com/danielpalme/IocPerformance/master/docs/img/Overview_Prepare_Fast.png)
### Machine
The benchmark was executed on the following machine:  
**CPU**: 12th Gen Intel(R) Core(TM) i7-12700K  
**Memory**: 95.78GB
