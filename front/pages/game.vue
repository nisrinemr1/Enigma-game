<template>
  <div class="home-page">

    <h1>Enigma game</h1>

    <p>hi {{localUser}}</p>

    <div v-for="enigma in list" :key="enigma.id">

      <p>niaaaah</p>
      <a @click="sendToUnity(enigma.id)">Enigma by {{enigma.user}} id = {{enigma.id}}</a>

    </div>

    <form @submit.prevent="submit">

      <input type="text" v-model="newEnigma" placeholder="Type your enigma sentence">

      <button> Send </button>

    </form>


    <canvas/>

  </div>
</template>


<script>
  export default {
    name: "game",
    data() {
      return {
        localUser: "",
        newEnigma: "",
        list : [
            {
              id: "w6DEQBUo9RbtfH2o1kmH",
              user: "Pikachu",
              title: "Petit test des familles"
            }
          ],
          title:""
      }
    },

    computed: {

      // list:   function () { return this.$store.state.enigma.list },
      // enigma: function () { 
      //   return this.$store.state.enigma.enigma 
      // }

    },

    // created(){

    //   this.title = this.$store.state.title

    // },

    methods: {

      submit() {

        // ANCHOR Const : variable jamais modifier (read only), let: variable modifiable uniquement dans la fonction, var: variable modifiable et utilisable dans plusieurs fonctions

        let isAscii = [...this.newEnigma].some(char => char.charCodeAt(0) > 127);

        //IF BOTH INPUT ARE EMPTY
        if (!this.newEnigma || isAscii) {

          alert("Use acii characters only ;)");
          this.newEnigma = "";

        } else {

          // SEND INPUT VALUES TO DATA
          // this.enigma.push({
          //   title: this.newEnigma,
          //   user: this.localUser
          // });

          //SEND TO STORE
          this.$store.dispatch('enigma/add', {
            user: this.localUser,
            title: this.newEnigma
          });

          alert("Your enigma has been send");
          this.newEnigma = "";
        }

      },
      // TODO

      sendToUnity(id) {
        this.$store.dispatch('enigma/getEnigma', {id});
        // console.log("bon normalement une fois que c'est fait le message est : " + this.enigma)
      },

    },


    mounted() {

      if (!localStorage.getItem('storedData')) {
        this.$router.push({
          path: "/"
        });
      } else {
        this.localUser = localStorage.getItem('storedData');
      }

    }
  }

</script>
