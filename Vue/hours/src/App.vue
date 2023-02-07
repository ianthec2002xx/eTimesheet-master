<template>
  <div id="app" class="is pulled-right">
    <header>
      <div class="is pulled-right">
    <b-button v-b-toggle.sidebar-no-header><b-icon icon="list"></b-icon> </b-button>  
    </div>
  </header>
  <div>
    <b-sidebar id="sidebar-no-header" aria-labelledby="sidebar-no-header-title" no-header shadow>
      <template #default="{ hide }">
        <div class="p-3">
          <nav class="mb-3">
            <b-nav vertical>
              <b-nav-item href="#/" @click="hide">Login</b-nav-item>
              <b-nav-item href="#/add-project" @click="hide">Projects</b-nav-item>
              <b-nav-item href="#/team" @click="hide">Teams</b-nav-item>
              <b-nav-item href="#/hours" @click="hide">Tasks</b-nav-item>
              <b-nav-item href="#/report" @click="hide">Reports</b-nav-item>
              <b-nav-item href="#/details" @click="hide">Details</b-nav-item>
              <b-nav-item href="#/member" @click="hide">Member</b-nav-item>
              <b-nav-item href="#/teammember" @click="hide">Team Member</b-nav-item>
            </b-nav>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <b-button variant="primary" block @click="hide"><b-icon icon="x-lg"></b-icon> </b-button>
          </nav>
            </div>
      </template>
    </b-sidebar>
  </div>
    <main>
      
      <!-- <div>
        <nav id="sidebar">
          <ul>
            <li>
              <a href="#/"><b-icon icon="house" align="left" height="28" width="28"></b-icon><span>Home</span></a>
            </li>
            <li>
              <a href="#/add-project"><b-icon icon="folder-plus" align="left" height="28" width="28"></b-icon><span mode="push" position="right">Project</span></a>
            </li>
            <li>
              <a href="#/team"><b-icon icon="diagram-3" align="left" height="28" width="28"></b-icon><span>Teams</span></a>
            </li>
            <li>
              <a href="#/hours"><b-icon icon="clipboard" align="left" height="28" width="28"></b-icon><span>Task</span></a>
            </li>
            <li>
              <a href="#/report"><span>Reports</span></a>
            </li>
            <li>
              <a href="#/details"><b-icon icon="clipboard" align="left" height="28" width="28"></b-icon><span>details</span></a>
            </li>
          </ul>
        </nav>
        </div> -->
      <router-view></router-view>
    </main> 
  </div>
</template>

<script>

  export default {
    data () {
      return {
      }
 
    }
  }
</script>

<style>
h1{
  text-align: center;
  margin-top: 40px;
}

body {
  margin: 0;
}

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #28C69F; ;
}

/* main {
  text-align: center;
  margin-top: 40px;
} */

*{
  padding: 0;
}

nav{
  position: absolute;
  top: 0;
  bottom: 0;
  height: 100%;
  left: 0;
  width: 320px;
  overflow: hidden;
  transition: push 0.2s linear ;
  background: #28C69F;
}

ul{
  height: 50%;
  display: flex;
  flex-direction: column;
  justify-content: space-around;  
}

li a{
  width: 160px;
  display: flex;
  align-items: center;
  justify-content: space-around;
  text-decoration: none;
  padding: 0;
}

a:hover{
  background: #eee;
}

nav:hover{
  width: 320px;
  transition: all 0.5s ease;
}

header {
  margin: 0;
  height: 56px;
  padding: 0 16px 0 24px;
  background-color: #DC143C; ;
  color: #DC143C; ;
}

header span {
  display: block;
  position: relative;
  font-size: 20px;
  line-height: 1;
  letter-spacing: .02em;
  font-weight: 400;
  box-sizing: border-box;
  padding-top: 16px;
  background-color: #28C69F; ;
  text-align: right;
}



#mySidenav a:hover {
  left: 0; /* On mouse-over, make the elements appear as they should 
}

/* The about link: 20px from the top with a green background */
}
#about {
  top: 60px;
  background-color: #28C69F;
}

#blog {
  margin-top: 8px;
  top: 120px;
  background-color: #28C69F; /* Blue */
}

#projects {
  margin-top: 16px;
  top: 180px;
  background-color: #28C69F; /* Red */
}

#contact {
  margin-top: 24px;
  top: 240px;
  background-color: #28C69F /* Light Black */
}

#report {
  margin-top: 32px;
  top: 300px;
  background-color: #28C69F 
}

#details {
  margin-top: 40px;
  top: 380px;
  background-color: #28C69F
}

</style>