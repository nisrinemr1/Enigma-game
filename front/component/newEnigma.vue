<template>
  <div>

    <form @submit.prevent="submit">

      <input type="text" v-model="newEnigma" placeholder="Type your enigma sentence">

      <button> Send </button>

    </form>

  </div>
</template>

<script>
  export default {

  }

</script>

<style lang="scss">



</style>
