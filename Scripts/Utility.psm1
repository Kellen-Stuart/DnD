function Confirm-Path {
    param(
        [Parameter(Mandatory=$true)]$Path
    )
    if(-not (Test-Path "$Path"))
    {
        Write-Error "$Path does not exist"
        return $false
    }

    return $true
}

Export-ModuleMember -Function Confirm-Path