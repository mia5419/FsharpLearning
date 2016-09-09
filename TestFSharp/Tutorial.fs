
let quadruple x =    
    let double x =
        x * 2

    double(double(x))
let value = quadruple(5)
printfn "The answer is: %d" value
 
 
#if COMPILED

module BoilerPlateForForm =
    [<System.STAThread>]
    do ()
//    do System.Windows.Forms.Application.Run()

#endif

