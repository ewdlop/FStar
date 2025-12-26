#light "off"
module LowStar_BufferView_Up

type inverses =
unit

type ('a, 'b) view =
| View of Prims.pos * unit * unit


let uu___is_View = (fun ( projectee  :  ('a, 'b) view ) -> true)


let __proj__View__item__n = (fun ( projectee  :  ('a, 'b) view ) -> (match (projectee) with
| View (n, get, put) -> begin
n
end))

type 'dest buffer =
| Buffer of unit * obj LowStar_BufferView_Down.buffer * (obj, 'dest) view


let uu___is_Buffer = (fun ( projectee  :  'dest buffer ) -> true)


let __proj__Buffer__item__down_buf = (fun ( projectee  :  'dest buffer ) -> (match (projectee) with
| Buffer (src, down_buf, v) -> begin
down_buf
end))


let __proj__Buffer__item__v = (fun ( projectee  :  'dest buffer ) -> (match (projectee) with
| Buffer (src, down_buf, v) -> begin
v
end))



let as_down_buffer = (fun ( bv  :  'b buffer ) -> (__proj__Buffer__item__down_buf bv))


let get_view = (fun ( v  :  'b buffer ) -> (__proj__Buffer__item__v v))


type 'h live =
(obj, obj, obj, 'h, obj) LowStar_Monotonic_Buffer.live


type ('h, 'hu) modifies =
(obj, 'h, 'hu) LowStar_Monotonic_Buffer.modifies




