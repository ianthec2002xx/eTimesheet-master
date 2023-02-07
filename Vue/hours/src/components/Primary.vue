<template>
    <div>
        <div class="container-fluid mt-4">
      <h1 class="h1" style="color: #28c69f">
        <b-icon icon="people"></b-icon>Project Teams</h1>
      <b-row>
        <b-col>
          <table class="table table-striped">
            <thead>
              <tr>
                <th>ID</th>
                <th>Project</th>
                <th>Name</th>
                <th>Member From</th>
                <th>Member To</th>
                <th>&nbsp;</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="record in records" :key="record.projectid">
                <td>{{ record.id }}</td>
                <td>{{ record.projectId}}</td>
                <td>{{ record.member}}</td>
                <td>{{ record.start }}</td>
                <td>{{ record.end }}</td>
                <td class="text-right">
                <a href="#" @click.prevent="updateFoodRecord(record)" v-b-modal.modal-1><b-icon icon="pencil-square"></b-icon>Edit</a> - 
                <a href="#" @click.prevent="deleteFoodRecord(record.id)"><b-icon icon="trash-fill"></b-icon>Delete</a>
              </td>
              </tr>
            </tbody>
          </table>
        </b-col>
      </b-row>
      </div>
        <!-- <div>
            <router-link to="/team/1"
                >go to post id 1</router-link
            >
        </div> -->

        <div>
            <router-link class="btn btn-warning" :to="{ name: 'AddProject' }"
                >Back to Projects</router-link
            >
        </div>
    </div>
</template>

<script>
import Axios from 'axios';
// import api from '@/ProjectTeamsApiService';
import api from '@/PrimaryApiService';
export default {
    // props: ['projectId'],
    data() {
        return {
            // teams: [],
            projectId: [],
            records: [],
            // teams: [],
            model:{}
        };
    },
    async created() {
        this.getAll()
      },
      beforeRouteUpdate() {
        console.log('Before route update in key model');
    },watch: {
        id() {
            console.log('props model');
            this.getKeymodel();
        },
    },
      methods: {
        async getAll() {
          this.loading = true
  
          try {
            this.records = await api.getAll()
          } finally {
            this.loading = false
          }
        },
        async updateFoodRecord(foodRecord) {
          // We use Object.assign() to create a new (separate) instance
          this.model = Object.assign({}, foodRecord)
        },
        async createFoodRecord() {
          const isUpdate = !!this.model.id;
  
          if (isUpdate) {
            await api.update(this.model.id, this.model)
          } else {
            await api.create(this.model)
          }
  
          // Clear the data inside of the form
          this.model = {}
  
          // Fetch all records again to have latest data
          await this.getAll()
        },
    },
    watch: {
        $route() {
            console.log('watch called');
            this.getKeys();
        },
    },
    created() {
        this.$watch(
            () => this.$route.params,
            () => {
                this.getKeys();
            },
        );

        console.log(this.$route);
        this.getKeymodel();
    },
    methods: {
        getKeymodel() {
            Axios.get(`keys.projectid=${this.projectid}`).then((response) => {
                this.key = response.data[this.projectid];
            });
        },
    },
};
</script>
