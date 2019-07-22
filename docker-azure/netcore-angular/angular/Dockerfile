ARG NODE_IMAGE=node:latest

FROM ${NODE_IMAGE} as node-build
WORKDIR /web
COPY . .
RUN pwd

WORKDIR /web/angular
RUN pwd

RUN npm install
RUN npm install -g @angular/cli 
RUN ng build --prod

############
### prod ###
############
RUN pwdcd
RUN ls

# base image
FROM nginx:1.16.0-alpine
RUN pwd

# copy artifact build from the 'build environment'
COPY --from=node-build /web/angular/dist /usr/share/nginx/html

# expose port 80
EXPOSE 80

# run nginx
CMD ["nginx", "-g", "daemon off;"]