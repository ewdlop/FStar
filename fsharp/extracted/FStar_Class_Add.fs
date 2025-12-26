#light "off"
module FStar_Class_Add
type 'a additive =
{zero : 'a; plus : 'a  ->  'a  ->  'a}


let __proj__Mkadditive__item__zero = (fun ( projectee  :  'a additive ) -> (match (projectee) with
| {zero = zero; plus = plus} -> begin
zero
end))


let __proj__Mkadditive__item__plus = (fun ( projectee  :  'a additive ) -> (match (projectee) with
| {zero = zero; plus = plus} -> begin
plus
end))


let zero = (fun ( projectee  :  'a additive ) -> (match (projectee) with
| {zero = zero1; plus = plus} -> begin
zero1
end))


let plus = (fun ( projectee  :  'a additive ) -> (match (projectee) with
| {zero = zero1; plus = plus1} -> begin
plus1
end))


let op_Plus_Plus = plus


let add_int : Prims.int additive = {zero = (Prims.parse_int "0"); plus = Prims.op_Addition}


let add_bool : Prims.bool additive = {zero = false; plus = Prims.op_BarBar}


let add_list = (fun ( uu___  :  unit ) -> {zero = []; plus = FStar_List_Tot_Base.append})




