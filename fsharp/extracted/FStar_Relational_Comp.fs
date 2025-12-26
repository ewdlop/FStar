#light "off"
module FStar_Relational_Comp

type heap2 =
FStar_Monotonic_Heap.heap FStar_Relational_Relational.double


type st2_Pre =
unit


type st2_Post' =
unit


type st2_Post =
unit


type st2_WP =
unit



let compose2 = (fun ( c0  :  'a0  ->  'b0 ) ( c1  :  'a1  ->  'b1 ) ( x  :  ('a0, 'a1) FStar_Relational_Relational.rel ) -> (failwith "Not yet implemented: FStar.Relational.Comp.compose2"))


let compose2_self = (fun ( f  :  'a  ->  'b ) ( x  :  'a FStar_Relational_Relational.double ) -> (compose2 f f x))


let cross = (fun ( c1  :  unit FStar_Relational_Relational.double  ->  ('a, 'b) FStar_Relational_Relational.rel ) ( c2  :  unit FStar_Relational_Relational.double  ->  ('c, 'd) FStar_Relational_Relational.rel ) -> (failwith "Not yet implemented: FStar.Relational.Comp.cross"))




let project_l = (fun ( c  :  ('a0, 'a1) FStar_Relational_Relational.rel  ->  ('b0, 'b1) FStar_Relational_Relational.rel ) ( x  :  'a0 ) -> (failwith "Not yet implemented: FStar.Relational.Comp.project_l"))


let project_r = (fun ( c  :  ('a0, 'a1) FStar_Relational_Relational.rel  ->  ('b0, 'b1) FStar_Relational_Relational.rel ) ( x  :  'a1 ) -> (failwith "Not yet implemented: FStar.Relational.Comp.project_r"))




