// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
import { collection, addDoc } from "firebase/firestore"; 


// -------------------- DATA --------------------
// -------------------- DATA --------------------
// -------------------- DATA --------------------
export const state = () => ({

    enigma: {
        user: "error",
        title: "error",
    }
})


// -------------------- MUTATION --------------------
// -------------------- MUTATION --------------------
// -------------------- MUTATION --------------------
export const mutations = {

}


// -------------------- ACTIONS --------------------
// -------------------- ACTIONS --------------------
// -------------------- ACTIONS --------------------
export const actions = {
    // GET ALL TITLES AND USER NAME
    async add({
        state
    }, {
        user,
        title
    }) {

        alert("coucouuuu :3");

        // const enigma = doc(collection(db, "enigma"))


        // await setDoc(enigma,{
        //     user: user,
        //     title: title
        // });


        // Add a new document with a generated id.
        const docRef = await addDoc(collection(db, "enigma"), {
            user: user,
            title: title
        }).catch((error) =>{
            console.log(error.code)
        });

        console.log("Document written with ID: ", docRef.id);
    }

}