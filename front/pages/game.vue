<template>
    <div class="home-page">

        <h1>Enigma game</h1>

        <p>hi {{userName}}</p>
        
        <div v-for="data in enigma">


            <p>Enigma by {{data.user}}</p>

        </div>

        <form @submit.prevent="submit">

            <input type="text" v-model="enigma.creator" placeholder="Type your enigma sentence">

            <button> Send </button>

        </form>

    </div>
</template>


<script>
    export default {
        name: "game",
        data() {
            return {
                enigma: [{
                    creator: this.$route.params.userName,
                    title: "hello"
                }],
                userName : this.$route.params.userName
            }
        },

        methods: {

            submit() {
                //IF BOTH INPUT ARE EMPTY
                if (!this.enigma.user && !this.enigma.creator) {
                    alert('Your message is empty');
                } else if (!this.enigma.user || !this.enigma.title) {
                    alert("An input is missing -_-");
                } else {
                    // SEND INPUT VALUES TO DATA
                    this.enigma.push({
                        creator: this.enigma.creator,
                        title: this.enigma.title
                    })

                    console.log(this.$route.params)
                    //SEND TO STORE
                    this.$store.dispatch('enigma/add',{
                            user: this.enigma.creator, 
                            title: this.enigma.title
                    })

                }

            }
        },

        
    }
</script>