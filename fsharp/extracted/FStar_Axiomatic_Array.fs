#light "off"
module FStar_Axiomatic_Array

type seq =
unit


let index = (fun ( uu___  :  seq ) ( uu___1  :  Prims.int ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.index"))


let update = (fun ( uu___  :  seq ) ( uu___1  :  Prims.int ) ( uu___2  :  'a ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.update"))


let emp = (fun ( uu___  :  unit ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.emp"))


let create = (fun ( uu___  :  Prims.int ) ( uu___1  :  'a ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.create"))


let length = (fun ( uu___  :  seq ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.length"))


let slice = (fun ( uu___  :  seq ) ( uu___1  :  Prims.int ) ( uu___2  :  Prims.int ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.slice"))


let append = (fun ( uu___  :  seq ) ( uu___1  :  seq ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.append"))


let proj_some = (fun ( uu___  :  seq ) -> (failwith "Not yet implemented: FStar.Axiomatic.Array.proj_some"))


type equal =
unit


type array =
seq FStar_Heap.ref


type is_Some_All =
unit




