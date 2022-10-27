// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
import { db } from "~/firebase/init";
import { collection, addDoc } from "firebase/firestore"; 


// -------------------- DATA --------------------
// -------------------- DATA --------------------
// -------------------- DATA --------------------
export const state = () => ({

    enigma: {
        userName: "error",
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
    async add({
        state
    }, {
        user,
        title
    }) {

        const docRef = await addDoc(collection(db, "enigma"), {
            user: user,
            title: title
        }).catch((error) =>{
            console.log(error.code)
        });
        console.log("Document written with ID: ", docRef.id);
    }


}