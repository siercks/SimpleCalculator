﻿global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using SimpleCalculator.DataContracts;
global using SimpleCalculator.DataContracts.Serialization;
global using SimpleCalculator.Models;
global using SimpleCalculator.Presentation;
global using SimpleCalculator.Services.Caching;
global using SimpleCalculator.Services.Endpoints;
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using Color = Windows.UI.Color;
[assembly: Uno.Extensions.Reactive.Config.BindableGenerationTool(3)]
