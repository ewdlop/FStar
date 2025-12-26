#light "off"
module FStar_WellFounded

type binrel =
unit


type well_founded =
unit


let rec fix_F = (fun ( f  :  'aa  ->  ('aa  ->  'r  ->  'p)  ->  'p ) ( x  :  'aa ) ( a  :  unit ) -> (f x (fun ( y  :  'aa ) ( h  :  'r ) -> (fix_F f y ()))))


let fix = (fun ( rwf  :  unit ) ( p  :  unit ) ( f  :  'aa  ->  ('aa  ->  'r  ->  obj)  ->  obj ) ( x  :  'aa ) -> (fix_F f x ()))


type is_well_founded =
unit


type well_founded_relation =
unit


type 'rel as_well_founded =
'rel





type 'subur subrelation_as_wf =
'subur


type 'rub inverse_image =
'rub







