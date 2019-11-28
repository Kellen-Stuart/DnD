Import-Module "$PSScriptRoot\Utility.psm1"

$common_dll_path = "$PSScriptRoot\..\Common\bin\Debug\netcoreapp3.0\Common.dll"

if((Confirm-Path -Path "$common_dll_path") -eq $false)
{
    return
}

Add-Type -AssemblyName "$common_dll_path" -PassThru