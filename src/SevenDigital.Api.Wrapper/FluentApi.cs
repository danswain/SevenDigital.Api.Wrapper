﻿<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5D2CA3D0-2220-46BF-B841-56FAA7EA3325}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>SevenDigital.Api.Wrapper</RootNamespace>
    <AssemblyName>SevenDigital.Api.Wrapper</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <GenerateSerializationAssemblies>Off</GenerateSerializationAssemblies>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Api.cs">
      <Link>Api.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\AppDomainAssemblyResolver.cs">
      <Link>EndpointResolution\AppDomainAssemblyResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\DictionaryExtensions.cs">
      <Link>EndpointResolution\DictionaryExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\EndPointInfo.cs">
      <Link>EndpointResolution\EndPointInfo.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\EndpointResolver.cs">
      <Link>EndpointResolution\EndpointResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\EssentialDependencyCheck.cs">
      <Link>EndpointResolution\EssentialDependencyCheck.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\IEndpointResolver.cs">
      <Link>EndpointResolution\IEndpointResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\OAuth\IUrlSigner.cs">
      <Link>EndpointResolution\OAuth\IUrlSigner.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\OAuth\OAuthBase.cs">
      <Link>EndpointResolution\OAuth\OAuthBase.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\EndpointResolution\OAuth\UrlSigner.cs">
      <Link>EndpointResolution\OAuth\UrlSigner.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Exceptions\ApiXmlException.cs">
      <Link>Exceptions\ApiXmlException.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Exceptions\MissingDependencyException.cs">
      <Link>Exceptions\MissingDependencyException.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasArtistIdParameterExtensions.cs">
      <Link>Extensions\HasArtistIdParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasBasketParameterExtensions.cs">
      <Link>Extensions\HasBasketParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasBasketParametersExtensions.cs">
      <Link>Extensions\HasBasketParametersExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasChartParameterExtensions.cs">
      <Link>Extensions\HasChartParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasKeyParameterExtensions.cs">
      <Link>Extensions\HasKeyParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasLetterParameterExtensions.cs">
      <Link>Extensions\HasLetterParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasPagingExtensions.cs">
      <Link>Extensions\HasPagingExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasPriceParameterExtensions.cs">
      <Link>Extensions\HasPriceParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasReleaseIdParameterExtensions.cs">
      <Link>Extensions\HasReleaseIdParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasSearchParameterExtensions.cs">
      <Link>Extensions\HasSearchParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasTrackIdParameterExtensions.cs">
      <Link>Extensions\HasTrackIdParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Extensions\HasUserDeliverItemParameterExtensions.cs">
      <Link>Extensions\HasUserDeliverItemParameterExtensions.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\FluentApi.cs">
      <Link>FluentApi.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\IApiUri.cs">
      <Link>IApiUri.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\IFluentApi.cs">
      <Link>IFluentApi.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\IOAuthCredentials.cs">
      <Link>IOAuthCredentials.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\HttpGetResolver.cs">
      <Link>Utility\Http\HttpGetResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\HttpPostResolver.cs">
      <Link>Utility\Http\HttpPostResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\IUrlResolver.cs">
      <Link>Utility\Http\IUrlResolver.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\IWebClientFactory.cs">
      <Link>Utility\Http\IWebClientFactory.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\IWebClientWrapper.cs">
      <Link>Utility\Http\IWebClientWrapper.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\WebClientFactory.cs">
      <Link>Utility\Http\WebClientFactory.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Http\WebClientWrapper.cs">
      <Link>Utility\Http\WebClientWrapper.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Serialization\ApiResourceDeSerializer.cs">
      <Link>Utility\Serialization\ApiResourceDeSerializer.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Serialization\ApiXmlDeSerializer.cs">
      <Link>Utility\Serialization\ApiXmlDeSerializer.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Serialization\IDeSerializer.cs">
      <Link>Utility\Serialization\IDeSerializer.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Serialization\ISerializer.cs">
      <Link>Utility\Serialization\ISerializer.cs</Link>
    </Compile>
    <Compile Include="..\..\SevenDigital.Api.Wrapper\Utility\Serialization\XmlSerializer.cs">
      <Link>Utility\Serialization\XmlSerializer.cs</Link>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="System">
      <HintPath>..\..\..\lib\Monodroid\System.dll</HintPath>
    </Reference>
    <Reference Include="System.Core">
      <HintPath>..\..\..\lib\Monodroid\System.Core.dll</HintPath>
    </Reference>
    <Reference Include="System.Xml">
      <HintPath>..\..\..\lib\Monodroid\System.Xml.dll</HintPath>
    </Reference>
    <Reference Include="System.Xml.Linq">
      <HintPath>..\..\..\lib\Monodroid\System.Xml.Linq.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\SevenDigital.Api.Schema\SevenDigital.Api.Schema.csproj">
      <Project>{FB977DE8-EE2A-478A-A029-4BDFF16E75DA}</Project>
      <Name>SevenDigital.Api.Schema %28Monodroid\SevenDigital.Api.Schema%29</Name>
    </ProjectReference>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <ProjectExtensions>
    <VisualStudio>
      <UserProperties ProjectLinkerExcludeFilter="\\?desktop(\\.*)?$;\\?silverlight(\\.*)?$;\.desktop;\.silverlight;\.xaml;^service references(\\.*)?$;\.clientconfig;^web references(\\.*)?$" ProjectLinkReference="42b4ee01-cdc9-482d-bbb1-b6147a6ea00d" />
    </VisualStudio>
  </ProjectExtensions>
</Project>