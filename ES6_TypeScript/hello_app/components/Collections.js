export function setCollections(){

    let Users_Music = new Set(['Raj','Heer','Madan']);
    let Users_Sports = new Set(['Ram','Meet','Reva']);

    let Music_Messages = ['Hey','Hie','Hello'];
    let Sports_Messages = ['Hey','Hie','Hello','Yo!'];

    // let Music_map_users = new Map();
    // Music_map_users.set('Music Users',Users_Music);
    // let Music_map_messages = new Map();
    // Music_map_messages.set('Music Messages',Music_Messages);

    // let Sports_map_users = new Map();
    // Sports_map_users.set('Sports Users',Users_Sports);
    // let Sports_map_messages = new Map();
    // Sports_map_messages.set('Music Messages',Sports_Messages);

    // console.log("Music Users are as follows -");
    // for (let [key, value] of Music_map_users.entries()) {
    //      console.log(key, value); 
    //     }

    // console.log("Music Messages are as follows -");
    // for (let [key, value] of Music_map_messages.entries()) {
    //      console.log(key, value); 
    //     }    

    // console.log("Sports Users are as follows -");    
    // for (let [key, value] of Sports_map_users.entries()) {
    //      console.log(key, value); 
    //     }

    // console.log("Sports Messages are as follows -");
    // for (let [key, value] of Sports_map_messages.entries()) {
    //      console.log(key, value); 
    //     }

    let Chatroom = new Map();
    Chatroom.set('Music Users',Users_Music);
    Chatroom.set('Sports Users',Users_Sports);
    Chatroom.set('Music Messages',Music_Messages);
    Chatroom.set('Sports Messages',Sports_Messages);

    for (let [key, value] of Chatroom.entries()) {
          console.log(key, value); 
         }
}