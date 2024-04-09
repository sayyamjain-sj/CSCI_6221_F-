open System
open System.IO
open System.Security.Cryptography

// Function to compute SHA256 hash of a file
let sha256Hash (filename:string) =
    use fs = new FileStream(filename, FileMode.Open, FileAccess.Read)
    use sha256 = SHA256.Create()
    sha256.ComputeHash(fs) |> BitConverter.ToString |> fun s -> s.Replace("-", "")

// Malware detection using SHA256
let malwareChecker (filepath:string) =
    let hashToCheck = sha256Hash filepath
    use malwareHashes = new StreamReader("VirusHashSHA256.txt")
    let rec loop () =
        match malwareHashes.ReadLine() with
        | null -> printfn "The file %s is clean." filepath 
        | line ->
            if line.Trim() = hashToCheck then
                printfn "The file %s is infected!" filepath
            else
                loop ()
    loop ()

malwareChecker "Virus2.docx"
