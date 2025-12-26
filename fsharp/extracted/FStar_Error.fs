#light "off"
module FStar_Error
type ('a, 'b) optResult =
| Error of 'a
| Correct of 'b


let uu___is_Error = (fun ( projectee  :  ('a, 'b) optResult ) -> (match (projectee) with
| Error (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Error__item___0 = (fun ( projectee  :  ('a, 'b) optResult ) -> (match (projectee) with
| Error (_0) -> begin
_0
end))


let uu___is_Correct = (fun ( projectee  :  ('a, 'b) optResult ) -> (match (projectee) with
| Correct (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Correct__item___0 = (fun ( projectee  :  ('a, 'b) optResult ) -> (match (projectee) with
| Correct (_0) -> begin
_0
end))


let perror : Prims.string  ->  Prims.int  ->  Prims.string  ->  Prims.string = (fun ( file  :  Prims.string ) ( line  :  Prims.int ) ( text  :  Prims.string ) -> text)


let correct = (fun ( x  :  'r ) -> Correct (x))


let rec unexpected = (fun ( s  :  Prims.string ) -> (

let uu___ = (FStar_IO.debug_print_string (Prims.strcat "Platform.Error.unexpected: " s))
in (unexpected s)))


let rec unreachable = (fun ( s  :  Prims.string ) -> (

let uu___ = (FStar_IO.debug_print_string (Prims.strcat "Platform.Error.unreachable: " s))
in (unreachable s)))


let if_ideal = (fun ( f  :  unit  ->  'a ) ( x  :  'a ) -> x)




