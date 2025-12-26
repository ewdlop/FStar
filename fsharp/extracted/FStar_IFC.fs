#light "off"
module FStar_IFC

type associative =
unit


type commutative =
unit


type idempotent =
unit

type semilattice =
| SemiLattice of unit * obj * (obj  ->  obj  ->  obj)


let uu___is_SemiLattice : semilattice  ->  Prims.bool = (fun ( projectee  :  semilattice ) -> true)


let __proj__SemiLattice__item__top : semilattice  ->  obj = (fun ( projectee  :  semilattice ) -> (match (projectee) with
| SemiLattice (carrier, top, lub) -> begin
top
end))


let __proj__SemiLattice__item__lub : semilattice  ->  obj  ->  obj  ->  obj = (fun ( projectee  :  semilattice ) -> (match (projectee) with
| SemiLattice (carrier, top, lub) -> begin
lub
end))


type sl =
unit


type lattice_element =
unit






let hide : unit  ->  unit  ->  unit  ->  obj  ->  obj = (fun ( sl1  :  unit ) ( l  :  unit ) ( b  :  unit ) ( x  :  obj ) -> x)


let return1 : unit  ->  unit  ->  unit  ->  obj  ->  obj = (fun ( sl1  :  unit ) ( a  :  unit ) ( l  :  unit ) ( x  :  obj ) -> (hide () () () x))


let map = (fun ( sl1  :  unit ) ( l  :  unit ) ( x  :  (obj, obj, 'a) protected1 ) ( f  :  'a  ->  'b ) -> (f x))


let join : unit  ->  unit  ->  unit  ->  unit  ->  obj  ->  obj = (fun ( sl1  :  unit ) ( l1  :  unit ) ( l2  :  unit ) ( a  :  unit ) ( x  :  obj ) -> x)


let op_let_Greater_Greater : unit  ->  unit  ->  unit  ->  obj  ->  unit  ->  unit  ->  (obj  ->  obj)  ->  obj = (fun ( sl1  :  unit ) ( l1  :  unit ) ( a  :  unit ) ( x  :  obj ) ( l2  :  unit ) ( b  :  unit ) ( f  :  obj  ->  obj ) -> (join () () () () (map () () x f)))




