<template>
  <div class="game-page">

    <h1>Enigma game</h1>


    <div class="container">
      <!-- ---------------- LEFT ---------------- -->
      <!-- ---------------- LEFT ---------------- -->
      <!-- ---------------- LEFT ---------------- -->
      <!-- <div class="left">
        <OnlineUsers />
      </div> -->



      <!-- ---------------- CENTER ---------------- -->
      <!-- ---------------- CENTER ---------------- -->
      <!-- ---------------- CENTER ---------------- -->

      <div class="center">
        <div class="first-part">
          <h2>Enigmas</h2>
          <div class="enigmaLinks" v-for="item in this.$store.state.enigma.list"> 
            <p @click="isHidden = !isHidden">Enigma by {{item.user}}</p>
            <div class="canva-container" v-if="!isHidden">

              <Webgl />

            </div>
          </div>
          <Explanation/>
        </div>






        <!-- <div class="create-enigma">

          <form @submit.prevent="sendMessage">

            <div class="form-container">
              <div class="input-new-enigma">

                <input class="type-enigma" type="text" v-model="newEnigma" placeholder="Type your enigma sentence">

              </div>

              <div class="submit-create">

                <button> Create</button>

              </div>

            </div>

          </form>

        </div> -->



      </div>

      <!-- <Webgl/> -->


      <!-- ---------------- RIGHT ---------------- -->
      <!-- ---------------- RIGHT ---------------- -->
      <!-- ---------------- RIGHT ---------------- -->
      <!-- <div class="right">
        <h2>Chat</h2>

        <div class="chat-area">
        <div class="test-message">
          <div class="chat-message" v-for="message in messages" :key="message">
            <h3>{{message.name}}</h3>
            <p class="message-text">{{message.text}}</p>
          </div>
        </div>
          
          <form class="chat-form" @submit.prevent="sendMessage">

            <div class="input-msg">

              <input class="its-the-end" type="text" v-model="newMessage" placeholder="Type your message">

            </div>

            <button> Send </button>

          </form>
        </div>

      </div> -->


    </div>

  </div>
</template>



<script>
  import Explanation from '~/component/explanation.vue';
import OnlineUsers from '~/component/onlineUsers.vue';
  import Webgl from '~/component/webgl.vue';

  export default {
    name: "game",
    data() {
      return {
        localUser: "",
        newEnigma: "",
        title: "",
        list: [],
        isHidden: true,
        newMessage: "",
        messages:[
          {
            name: "Babouche ⛑️",
            text: "Coucou, ça va la compagne ?"
          },
          {
            name: "Céryale Dora 🔪",
            text: "Yo, ouai tranquillou, en vrai, chaud le premier à décrypter la blague de Callypse, ça te tente ?"
          },
          {
            name: "Babouche ⛑️",
            text: "Yes, ça va faire un trophée en plus dans mon palmarès !"
          },
          {
            name: "Céryale Dora 🔪",
            text: "T'avances pas trop vite haha !"
          },
        ]
      };
    },


    watch: {
      list() {
        console.log("SanGoku")
        console.log(this.list)
      }
    },

    created() {
      this.$store.dispatch("enigma/getAll").then(() => {
        this.list = this.$store.state.enigma.list;
        console.log("ici");
      })
      // console.log(this.$store.state.enigma.list);
    },

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
          this.$store.dispatch("enigma/add", {
            user: this.localUser,
            title: this.newEnigma
          });
          alert("Your enigma has been send");
          this.newEnigma = "";
        }
      },

      sendMessage(){

        // SEND MESSAGE
        this.messages.push({
          name: this.localUser,
          text: this.newMessage
        });
        
      },

      // TODO
      sendToUnity(id) {
        this.$store.dispatch("enigma/getEnigma", {
          id
        });
        // console.log("bon normalement une fois que c'est fait le message est : " + this.enigma)
      },
    },


    mounted() {
      if (!localStorage.getItem("storedData")) {
        this.$router.push({
          path: "/"
        });
      } else {
        this.localUser = localStorage.getItem("storedData");
      }
    },


    components: {
    OnlineUsers,
    Webgl,
    Explanation
}
  }

</script>


<style lang="scss">
  .game-page {

    width: 100%;
    height: 95vh;

    display: flex;
    flex-direction: column;
    align-items: center;

    .home-enter-active,
    .home-leave-active {
      transition: opacity .5s;
    }

    .home-enter,
    .home-leave-active {
      opacity: 0;
    }

    h1 {
      width: 90%;
      text-align: start;
    }

    .container {

      width: 90%;
      height: 90%;

      z-index: 1;


      display: flex;
      justify-content: center;



      .left {

        object-fit: contain;

        border: rgb(4, 235, 235) 2px double;

        background: linear-gradient(to bottom, rgba(43, 237, 230, 0.1) 0%, rgba(43, 237, 230, 0.2) 100%);


        width: 15%;
        height: 100%;
        height: 100%;

      }


      .center {
        background: linear-gradient(to bottom, rgba(43, 237, 230, 0.1) 0%, rgba(43, 237, 230, 0.2) 100%);
        border: rgb(4, 235, 235) 2px double;

        width: 100%;
        height: 100%;

        position: relative;

        .first-part {

          height: 100%;
          overflow-y: none;
          position: relative;


          h2 {
            padding-top: 5px;
            padding-left: 10px;
            padding-bottom: 5px;
            border-bottom: rgb(4, 235, 235) 1px solid;
          }

          .enigmaLinks{

            height: 100%;

            p{

              margin-left: 40px;
              margin-bottom: 10px;

              cursor: pointer;
              width: 40%;

              border-bottom: transparent 3px solid;

              &:active, &:hover{

                border-bottom: rgb(4, 235, 235) 3px solid;
                transition: all .3s ease-in-out;
              }
            }

            .canva-container {
              overflow: hidden;
              height: 70vh;

              display: flex;
              align-items: center;
              justify-content: center;

            }
          }


        }

        .create-enigma {

          width: 100%;
          height: 20%;

          display: flex;
          flex-direction: column;

          position: absolute;

          bottom: 0;

          form {

            width: 100%;

            display: flex;
            flex-direction: column;
            align-items: flex-end;


            .form-container {

              width: 50%;

              position: relative;

              display: flex;
              flex-direction: column;
              align-items: flex-end;
              justify-content: center;

              .input-new-enigma {

                width: 100%;
                height: 100%;

                margin-bottom: 20px;

                .type-enigma {
                  width: 93%;
                }

              }

              .submit-create {
                width: 100%;
                height: auto;
                display: flex;
                justify-content: flex-end;
                button{
                  margin-top: 10px;
                  margin-right: 10px;
                }
              }

            }

          }

        }



      }

      .right {
        background: linear-gradient(to bottom, rgba(43, 237, 230, 0.1) 0%, rgba(43, 237, 230, 0.2) 100%);
        border: rgb(4, 235, 235) 2px double;

        width: 15%;

        height: 100%;
        position: relative;

        h2 {
          padding-top: 5px;
          padding-left: 10px;
          padding-bottom: 5px;
          border-bottom: rgb(4, 235, 235) 1px solid;
        }

        .test-message{
          overflow-y: scroll;
          overflow-x: hidden;
          width: 100%;
          height: 400px;

          .chat-message{
            overflow-y: hidden;

            .message-text{
              width: 70%;
              overflow-x: visible;
            }
          }
        }

        .chat-form {
          display: flex;
          flex-direction: column;
          align-items: flex-end;
          justify-content: flex-end;
          width: 100%;
          height: 35vh;

          .its-the-end{
            margin-bottom: 50px;
          }

          button {
            margin-top: 50px;
            width: 50%;
            margin-right: 10px;

          }

        }

      }
    }

  }

</style>
