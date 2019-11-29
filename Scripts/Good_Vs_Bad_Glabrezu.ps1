$good_glabrezu = New-Object Common.Monsters.Glabrezu
$good_glabrezu.PointOnMap = New-Object System.Drawing.Point @(0, 0)

$bad_glabrezu = New-Object Common.Monsters.Glabrezu
$bad_glabrezu.PointOnMap = New-Object System.Drawing.Point @(1, 1)

[Global]::Map.InsertPhysicalObject($good_glabrezu, (New-Object System.Drawing.Point @(0, 0)))
[Global]::Map.InsertPhysicalObject($bad_glabrezu, (New-Object System.Drawing.Point @(1, 1)))

Write-Host "Good Glabrezu is going to perform Unarmed Strike on Bad Glabrezu"
Write-Host "Bad Glabrezu HP: " + $bad_glabrezu.HitPoints
$good_glabrezu.Actions[0].Execute($bad_glabrezu.PointOnMap)