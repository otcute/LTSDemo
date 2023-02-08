import axiosClient from '../AxiosApi';

const studentManagerApi: any = {
    login: (param: any) => {
        const url = `/api/product1.0/checklogin?userName=${param.userName}&userPass=${param.userPass}`;
        return axiosClient.get(url);
    },
    login1: (param: any) => {
        const url = `/api/timtheoid?studentId=1`
        return axiosClient.get(url);
    },
    signin: (data: any) => {
        const url = `/api/product1.0/createaccount`;
        return axiosClient.post(url, data, {});
    },
};

export default studentManagerApi;
