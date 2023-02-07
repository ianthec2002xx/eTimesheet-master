import Vue from 'vue'
import axios from 'axios'

const client = axios.create({
  baseURL: 'https://localhost:7190/api/project',
  json: true
})

export default {
    async execute(method, resource, data) {
      return client({
        method,
        url: resource,
        data,
      }).then(req => {
        return req.data
      })
    },
    getAll() {
      return this.execute('get', '/')
    },
    create(data) {
      return this.execute('post', '/', data)
    },
    update(id, data) {
      return this.execute('put', `/${id}`, data)
    },
    delete(id, data) {
      return this.execute('delete', `/${id}`, data)
    }
  }