let nme:string="demo";

let num:number=24.56;

let isOk:boolean=true;

let unionType:string | number | boolean = true;

let know:unknown=34;

//Any can store almost anything
let go:any="de"


let tuple:[string,number]=["string",34,54,23];

let names:string[] | number[] = ["Vikrant","Sushil","Harshal","Anjali"];

let anyarray:any=["Radha",21,true,93.27];

console.log(names[0]);

console.log(tuple[0]);
console.log(anyarray[3]);


let anonymousfunc=function(x:number,y:number):number
{
    return x+y;
}

console.log(anonymousfunc(5,4));


let lambda=(x:number,y:number):number=>x+y;

console.log(lambda(5,10));


function Demo(x:number,y:number=10)
{
    return x+y;
}

console.log(Demo(4));


function Demo1(x:string,y:number,z:number)
{
    return x+y+z;
}

console.log(Demo1("Age: ",1,2));

