# Buber Dinner API

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register Request

```json
    "firstName": "Radosław",
    "lastName": "Grzanka",
    "email": "r@gmail.com",
    "password": "srasłord"
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "123456789-1234-1234-1234-123456789abc",
    "firstName": "Radosław",
    "lastName": "Grzanka",
    "email": "r@gmail.com",
    "token": "eyfdj..jfjf"
}
```

### Login

#### Login Request

```json
    "email": "r@gmail.com",
    "password": "srasłord"
```

#### Login Response

```json
{
    "id": "123456789-1234-1234-1234-123456789abc",
    "firstName": "Radosław",
    "lastName": "Grzanka",
    "email": "r@gmail.com",
    "token": "eyfdj..jfjf"
}
```
