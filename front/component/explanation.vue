<template>
  <div class="explanation">
    <div class="ex-container">
      <p :class="'test ' + showWindow">
        <span>How to play:</span> <br />
        <br />Please click in the game window so that your mouse is the cursor. Move
        around the game using the arrows on your keyboard. Click on the floating objects'
        squares and explore around you to find the enigma!
        <br />
        <br />
        <br />
        <!-- <span>Explanation of the game:</span><br>
                <br>
The goal of the game is to find the puzzle by finding the letters thanks to the floating objects. On one of the sides of the monolith, you will find the pseudocode to decipher in order to find the ascii value of the letter of the floating object according to its position, its transformation and its color. Then, once the number is found, find the letter that corresponds to the number found in the second face of the monolith. -->
      </p>
      <button @click="showWindow = !showWindow">?</button>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      showWindow: false,
    };
  },
};
</script>

<style lang="scss">
.explanation {
  position: fixed;

  width: auto;
  height: 0;

  background-color: chartreuse;

  display: flex;
  justify-content: flex-end;
  align-items: flex-end;

  .ex-container {
    width: 70vh;
    height: 70vh;

    margin: 50px 70px;

    display: flex;
    align-items: flex-end;
    justify-content: flex-end;

    .true {
      visibility: visible;
      background: rgb(25, 26, 35);

      padding: 20px;

      height: 90%;

      transition: all 0.4s ease-in-out;

      border: 2px double rgb(4, 235, 235);

      span {
        font-weight: bolder;
      }
    }

    .false {
      visibility: hidden;
      transition: all 0.4s ease-in-out;
    }

    button {
      border-radius: 100%;

      padding: 20px 40px;
      // padding: 20px 30px;
      margin: 10px 10px;

      display: flex;
      justify-content: center;
      align-items: center;

      font-size: 2.3rem;
    }
  }
}
</style>
