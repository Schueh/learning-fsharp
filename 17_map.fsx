let inventory =
    [ "Apples", 0.33; "Oranges", 0.23; "Bananas", 0.45 ]
    |> Map.ofList

let apples = inventory.["Apples"]
let pineapples = inventory.["Pineapples"] // will throw KeyNotFoundException

let newInventory =
    inventory
    |> Map.add "Pineapples" 0.87
    |> Map.remove "Apples"

let cheapFruit, expensiveFruit =
    inventory
    |> Map.partition(fun fruit cost -> cost < 0.3)