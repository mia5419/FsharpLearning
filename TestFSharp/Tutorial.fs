
let chrisTest test =
    test "Chris"

let isMe x =
    if x = "Chris" then
        "it is Chris!"
    else
        "it's someone else"

let value = chrisTest isMe
printfn "The answer is: %A" value
 
#if COMPILED

module BoilerPlateForForm =
    [<System.STAThread>]
    do ()

#endif

