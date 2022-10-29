// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
// -------------------- IMPORT FROM INIT.JS --------------------
import {
  db
} from "~/firebase/init";
import {
  collection,
  addDoc,
  getDocs,
} from "firebase/firestore";


// -------------------- DATA --------------------
// -------------------- DATA --------------------
// -------------------- DATA --------------------
export const state = () => ({

  enigma: null,

  list: []
})


// -------------------- MUTATION --------------------
// -------------------- MUTATION --------------------
// -------------------- MUTATION --------------------
export const mutations = {

  editEnigmas(state, list){
   // console.log(list);
    state.list = list
    // console.log(state.list);
  }

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
    }).catch((error) => {
      console.log(error.code)
    });
    console.log("Document written with ID: ", docRef.id);
  },


  async getAll({
    commit
  }) {

    var list = []

    const querySnapshot = await getDocs(collection(db, "enigma"));
    querySnapshot.forEach((doc) => {
      // doc.data() is never undefined for query doc snapshots
      list.push({
        id: doc.id,
        user: doc.data().user,
        title: doc.data().title
      });

      //console.log(doc.id, " => ", doc.data());

    });

    commit("editEnigmas", list);
  }
}
