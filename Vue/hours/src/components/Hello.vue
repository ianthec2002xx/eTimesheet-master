<template>
    <div class="hello">
      <main>
        <h1> <img src="@/assets/logo.png" alt=""></h1>
        <p>Welcome to eTimesheet</p>
        <form>
        <div class="container-fluid mt-3">
          <center>
        <b-col lg="3">
              <b-input-group class="mb-3">
                <b-input-group-prepend is-text>
                  <b-icon icon="person-fill"></b-icon>
                </b-input-group-prepend>
                <b-form-input type="text" placeholder="Username"></b-form-input>
              </b-input-group>
              <br>
              <b-input-group class="mb-3">
                <b-input-group-prepend is-text>
                  <b-icon icon="lock-fill"></b-icon>
                </b-input-group-prepend>
                <b-form-input type="password" placeholder="Password"></b-form-input>
              </b-input-group>
              </b-col>
            </center>
              <div>
                <br>
                <b-form-group>
                <b-btn type="submit" variant="success">Login</b-btn>
                <b-btn variant="link" ><text-align>center</text-align>Forgot password?</b-btn>
                </b-form-group>
              </div>
            </div> 
            </form>
          </main>
      <!-- <b-footer style="color: white; position:relative;">
        <b-row>
          Global Health Informatics Institute
          <b-col> <p>Area 3/719 Off Beit Road, Lilongwe, Malawi</p> Phone: +265 999 947 966 / +265 995 084 444</b-col>
          <b-col sm="auto"><p>Post Office Box X111, Crossroads</p> Lilongwe, Malawi</b-col>
        </b-row>
      </b-footer> -->
    </div> 
  
  </template>
  
  <script>
  export default {
   
  }
  </script>
  
  <style>
  /* b-footer { 
  margin-top: 80px;
  display: block; 
  padding: 0 16px 0 24px;
  background-color: #28C69F; 
  height: 100px; 
  }  */
  body {
    margin: 0;
    left: 100px;
  }
  
  #app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    color: #2c3e50;
    box-align: left;
  }
  
  
  
  </style>
  