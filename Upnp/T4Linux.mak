# Makefile for T4 on linux
# Could be extended to support Mac in future

# Macros used by T4.mak

toolsDir = Build/Posix/Tools/
t4 = $(toolsDir)TextTransform.exe
upnpServiceXml = $(toolsDir)UpnpServiceXml.dll
upnpServiceMake = $(toolsDir)UpnpServiceMake.dll
argumentProcessor = $(toolsDir)ArgumentProcessor.dll
proxySrcCppCore = ControlPoint/Services/Cpp/Core/
proxyApiCppCore = Api/Cpp/Core/
proxyApiC = Api/C/
proxySrcC = ControlPoint/Services/C/
proxyApiCppStd = Api/Cpp/Std/
proxySrcCppStd = ControlPoint/Services/Cpp/Std/
proxyCs = ControlPoint/Services/Cs/
proxyJs = ControlPoint/Services/Js/
deviceSrcCppCore = Device/Services/Cpp/Core/
deviceApiCppCore = $(proxyApiCppCore)
deviceSrcCppStd = Device/Services/Cpp/Std/
deviceApiCppStd = $(proxyApiCppStd)
deviceSrcC = Device/Services/C/
deviceApiC = $(proxyApiC)
deviceCs = Device/Services/Cs/
tt = $(toolsDir)UpnpServiceXml.dll $(toolsDir)UpnpServiceMake.dll $(toolsDir)Mono.TextTemplating.dll $(toolsDir)TextTransform.exe

tt : $(tt)

dllsources =	T4/TextTemplating/Mono.TextTemplating/AssemblyInfo.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/DirectiveProcessor.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/DirectiveProcessorException.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/RequiresProvidesDirectiveProcessor.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/ToStringHelper.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/ITextTemplatingEngineHost.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/Engine.cs \
                T4/TextTemplating/Mono.TextTemplating/Microsoft.VisualStudio.TextTemplating/TextTransformation.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/TemplatingEngine.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/CrossAppDomainAssemblyResolver.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/TemplateGenerator.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/Tokeniser.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/IExtendedTextTemplatingEngineHost.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/TemplateSettings.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/ParsedTemplate.cs \
                T4/TextTemplating/Mono.TextTemplating/Mono.TextTemplating/CompiledTemplate.cs

$(toolsDir)Mono.TextTemplating.dll : $(dllsources)
	@mkdir -p $(toolsDir)
	gmcs /t:library -out:$(toolsDir)Mono.TextTemplating.dll $(dllsources)

 
exesources =	T4/TextTemplating/TextTransform/AssemblyInfo.cs \
               	T4/TextTemplating/TextTransform/Options.cs \
               	T4/TextTemplating/TextTransform/TextTransform.cs

$(toolsDir)TextTransform.exe : $(toolsDir)Mono.TextTemplating.dll $(exesources)
	@mkdir -p $(toolsDir)
	gmcs /t:exe -out:$(toolsDir)TextTransform.exe /r:$(toolsDir)Mono.TextTemplating.dll $(exesources)

$(toolsDir)UpnpServiceDescription.xsd : T4/UpnpServiceXml/UpnpServiceDescription.xsd
	@mkdir -p $(toolsDir)
	cp -u T4/UpnpServiceXml/UpnpServiceDescription.xsd $(toolsDir)

$(toolsDir)UpnpServiceTemplate.xsd : T4/UpnpServiceXml/UpnpServiceTemplate.xsd
	@mkdir -p $(toolsDir)
	cp -u T4/UpnpServiceXml/UpnpServiceTemplate.xsd $(toolsDir)

xmlsources = 	T4/UpnpServiceXml/AssemblyInfo.cs \
               	T4/UpnpServiceXml/UpnpServiceXml.cs

$(toolsDir)UpnpServiceXml.dll: $(toolsDir)UpnpServiceDescription.xsd $(toolsDir)UpnpServiceTemplate.xsd $(xmlsources)
	@mkdir -p $(toolsDir)
	gmcs -target:library -out:$(upnpServiceXml) $(xmlsources)
	
upnpservicemake.sources =   T4/UpnpServiceMake/AssemblyInfo.cs \
                            T4/UpnpServiceMake/UpnpServiceMake.cs

$(toolsDir)UpnpServiceMake.dll : $(upnpservicemake.sources)
	@mkdir -p $(toolsDir)
	gmcs -target:library -out:$(upnpServiceMake) $(upnpservicemake.sources)

clean-t4:
	if test -d $(toolsDir); then rm -r $(toolsDir); fi

