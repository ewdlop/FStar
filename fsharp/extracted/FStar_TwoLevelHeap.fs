#light "off"
module FStar_TwoLevelHeap

type rid =
Prims.int


type t =
(rid, FStar_Monotonic_Heap.heap) FStar_Map.t


type st_pre =
unit


type st_post' =
unit


type st_post =
unit


type st_wp =
unit


type 'a rref =
'a FStar_Heap.ref


let as_ref = (fun ( id  :  rid ) ( r  :  'a rref ) -> r)


let ref_as_rref = (fun ( i  :  rid ) ( r  :  'a FStar_Heap.ref ) -> r)


let new_region : unit  ->  rid = (fun ( uu___  :  unit ) -> (failwith "Not yet implemented: FStar.TwoLevelHeap.new_region"))


let ralloc = (fun ( i  :  rid ) ( init  :  'a ) -> (failwith "Not yet implemented: FStar.TwoLevelHeap.ralloc"))


let op_Colon_Equals = (fun ( i  :  rid ) ( r  :  'a rref ) ( v  :  'a ) -> (failwith "Not yet implemented: FStar.TwoLevelHeap.op_Colon_Equals"))


let op_Bang = (fun ( i  :  rid ) ( r  :  'a rref ) -> (failwith "Not yet implemented: FStar.TwoLevelHeap.op_Bang"))


let get : unit  ->  t = (fun ( uu___  :  unit ) -> (failwith "Not yet implemented: FStar.TwoLevelHeap.get"))


type 'm1 modifies =
(rid, FStar_Monotonic_Heap.heap, 'm1, obj) FStar_Map.equal


type fresh_region =
unit


type contains_ref =
unit


type fresh_rref =
unit




