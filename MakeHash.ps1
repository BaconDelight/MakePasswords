
cls
""

$Path = Read-Host -Prompt "Enter File Path"

$Hash = @()

$Hash += Get-FileHash $Path -Algorithm MD5
$Hash += Get-FileHash $Path -Algorithm SHA256
$Hash += Get-FileHash $Path -Algorithm SHA512

$Hash | ft Algorithm,Hash  


Read-Host -Prompt "Press <Return> to continue"
""
