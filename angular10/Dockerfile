# Stage 1

FROM node:16.14.0 as build-step

RUN mkdir -p /app

WORKDIR /app

COPY package.json /app

RUN npm install

COPY . /app

RUN npm run build --prod

# Stage 2

FROM nginx:1.17.1-alpine

COPY --from=build-step /app/dist/angular10 /usr/share/nginx/html

# expose port 80
EXPOSE 80
