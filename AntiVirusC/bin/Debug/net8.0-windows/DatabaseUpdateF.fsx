
open System.IO

let copyContents (sourceFilePath: string) (destinationFilePath: string) =
    try
        // Read all text from the source file
        let fileContents = File.ReadAllText(sourceFilePath)
        
        // Write the contents to the destination file
        File.WriteAllText(destinationFilePath, fileContents)
        
        printfn "File copied successfully!"
    with
    | :? System.IO.IOException as ex ->
        printfn "An error occurred while copying the file: %s" ex.Message
    | ex ->
        printfn "An unexpected error occurred: %s" ex.Message

// Example usage
let sourceFile = "source.txt"
let destinationFile = @"C:\Users\naiti\OneDrive\Desktop\GW Studies\ProjectSYN\VirusHashSHA256Database.txt"

copyContents sourceFile destinationFile
