export function Arrow(){

    let a1 = ['Tom', 'Ivan', 'Jerry'];

    let array_to_obj = a1.map(obj_create=> {
        return{name:obj_create,length:obj_create.length}
    });
    console.log(array_to_obj);
}