#light "off"
module LowStar_BufferOps

let op_Array_Access = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.index)


let op_Array_Assignment = (fun ( b  :  ('a, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( v  :  'a ) -> (

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' b i v)))


let op_Bang_Star = (fun ( p  :  ('a, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) -> (LowStar_Monotonic_Buffer.index p (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let op_Star_Equals = (fun ( p  :  ('a, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( v  :  'a ) -> (

let h = (FStar_HyperStack_ST.get ())
in (LowStar_Monotonic_Buffer.upd' p (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) v)))


let blit = (fun ( uu___  :  unit ) -> LowStar_Monotonic_Buffer.blit)




