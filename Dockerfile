FROM mcr.microsoft.com/windows/servercore/iis:windowsservercore-ltsc2019

SHELL ["powershell"]

RUN Install-WindowsFeature NET-Framework-45-ASPNET ; \
    Install-WindowsFeature Web-Asp-Net45


COPY RestierServiceV2 RestierServiceV2

RUN Remove-WebSite -Name 'Default Web Site'
RUN New-Website -Name 'odata' -Port 59450 \
    -PhysicalPath 'c:\RestierServiceV2' -ApplicationPool '.NET v4.5'
EXPOSE 59450