namespace Game

open System
open Game.Domain

module Brains =

    let rng = Random ()
          
    let dice = fun () -> rng.Next()
           
    let randomDecide () = 
        match (dice () % 3) with
        | 0 -> Straight
        | 1 -> Left
        | 2 -> Right