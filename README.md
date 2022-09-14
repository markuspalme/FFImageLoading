# FFImageLoading - Fast & Furious Image Loading 

This is a port of the iOS version of  `FFImageLoadingLibrary` https://github.com/luberda-molinet/FFImageLoading) to .NET 6
only supporting the `net6-ios` TFM.

Available on NuGet as `Portalworkers.FFImageLoading.NetIos` (https://www.nuget.org/packages/Portalworkers.FFImageLoading.NetIos/).

Original Authors: Daniel Luberda, Fabien Molinet.

Port by: Markus Palme



## Features

- .NET 6 iOS support
- Configurable disk and memory caching
- Multiple image views using the same image source (url, path, resource) will use only one bitmap which is cached in memory (less memory usage)
- Deduplication of similar download/load requests. *(If 100 similar requests arrive at same time then one real loading will be performed while 99 others will wait).*
- Error and loading placeholders support
- Images can be automatically downsampled to specified size (less memory usage)
- Fluent API which is inspired by Picasso naming
- Image loading Fade-In animations support
- Can retry image downloads (RetryCount, RetryDelay)

## Original Documentation

https://github.com/luberda-molinet/FFImageLoading/wiki

