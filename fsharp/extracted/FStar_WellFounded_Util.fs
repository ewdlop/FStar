#light "off"
module FStar_WellFounded_Util

type top =
(unit, obj) Prims.dtuple2


type 'r lift_binrel =
(unit, 'r) Prims.dtuple2


let lower_binrel = (fun ( x  :  top ) ( y  :  top ) ( p  :  'r lift_binrel ) -> (FStar_Pervasives.dsnd p))





type 'r lift_binrel_as_well_founded_relation =
'r lift_binrel


type lift_binrel_squashed =
unit


type squash_binrel =
unit





type lift_binrel_squashed_as_well_founded_relation =
unit







